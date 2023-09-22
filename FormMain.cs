using System.Text;
using Path = System.IO.Path;
using ImageMagick;
using System.Diagnostics;

namespace monkey_image
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            SetDefaultAttrComponent();
            InitializeTypeMap();
        }

        public enum CornType
        {
            TopLeft,        //顶部左边
            TopCenter,      //顶部中间
            TopRight,       //顶部右边
            BottomLeft,     //底部左边
            BottomCenter,   //底部中间
            BottomRight     //底部右边
        }

        // 设置组件的默认属性
        private void SetDefaultAttrComponent()
        {
            comboBoxCorner.SelectedIndex = 3; //底部左边
            font = new Font("楷体", 80, FontStyle.Bold);
            textBoxFont.Text = font.ToString();
        }

        private void InitializeTypeMap()
        {
            typeMap = new Dictionary<string, HandleImage>(){
                {".jpg", handleJpg},
                {".jpeg", handleJpg},
                {".heic", handleHeic}
            };
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePaths = openFileDialog.FileNames;
                if (filePaths.Length > 0)
                {
                    textBoxDir.Text = Path.GetDirectoryName(filePaths[0]);
                }
            }
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (filePaths == null || filePaths.Length == 0)
            {
                return;
            }
            Debug.WriteLine("processing start");
            buttonStart.Enabled = false;
            toolStripProgressBar.Minimum = 0;
            toolStripProgressBar.Maximum = filePaths.Length;
            toolStripProgressBar.Value = 0;
            toolStripProgressBar.Step = 1;
            foreach (var one in filePaths)
            {
                // TODO 使用协程池
                var res = handleImageEntry(one);
                if (res == false)
                {
                    Debug.WriteLine("processing failed", one);
                }
                toolStripProgressBar.PerformStep();
            }
            buttonStart.Enabled = true;

            Debug.WriteLine("processing end");
        }
        private void buttonFont_Click(object sender, EventArgs e)
        {
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                font = fontDialog.Font;
                textBoxFont.Text = font.ToString();
            }
        }


        // 处理图片入口
        private bool handleImageEntry(string file)
        {
            var ext = Path.GetExtension(file).ToLower();
            if (typeMap.ContainsKey(ext))
            {
                var h = typeMap[ext];
                if (h != null)
                {
                    return h(file);
                }
            }
            return true;
        }

        private bool handleJpg(string file)
        {
            string datetime = DateTime.Now.ToString("yyyy/MM/dd");

            Debug.WriteLine("handleJpg");
            using Bitmap fileBitMap = new Bitmap(file);
            var prop = fileBitMap.GetPropertyItem(0x9003);
            if (prop != null)
            {
                datetime = Encoding.Default.GetString(prop.Value).Trim('\0');
                Debug.WriteLine("{0} datetime: {1}", file, datetime);
                datetime = datetime.Split(' ')[0].Replace(':', '/');
            }
            var text = getFrontCaption() + datetime + getBackCaption();
            Debug.WriteLine("{0} text: {1}", file, text);

            // 获取图像宽度和高度
            int width = fileBitMap.Width;
            int height = fileBitMap.Height;
            Size size = TextRenderer.MeasureText(text, font);
            int childWidth = size.Width;
            int childHeight = size.Height;
            Debug.WriteLine("MeasureText size: {0},{1}", size.Width, size.Height);
            Point point = calcCoordinate(width, height, childWidth, childHeight);

            // 创建元数据区域
            using Bitmap metaBitmap = new Bitmap(childWidth, childHeight);

            // 设置字体和颜色
            SolidBrush brush = new SolidBrush(Color.Yellow);

            // 在元数据区域中绘制文本框
            using Graphics metaGraph = Graphics.FromImage(metaBitmap);
            metaGraph.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            metaGraph.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            metaGraph.DrawString(text, font, brush, new Rectangle(0, 0, childWidth, childHeight));

            // 将元数据区域合并到主图像上
            using Graphics fileGraph = Graphics.FromImage(fileBitMap);
            fileGraph.DrawImage(metaBitmap, new Rectangle(point.X, point.Y, childWidth, childHeight));

            // 保存修改后的图像到磁盘
            string outputFile = "Output_" + Path.GetFileNameWithoutExtension(file) + ".jpg";
            string outputPath = Path.Combine(Path.GetDirectoryName(file), outputFile);
            fileBitMap.Save(outputPath);

            Debug.WriteLine("handle end", file);
            return true;
        }

        private bool handleHeic(string file)
        {
            string datetime = DateTime.Now.ToString("yyyy/MM/dd");

            Debug.WriteLine("handleHeic");
            using MagickImage inputImage = new MagickImage(file);
            if (inputImage == null)
            {
                Debug.WriteLine("open file failed:{0}", file);
                return false;
            }
            var height = inputImage.Height;
            var width = inputImage.Width;

            var exif = inputImage.GetExifProfile();
            var value = exif.GetValue(ExifTag.DateTimeOriginal);
            if (value != null)
            {
                var str = value.Value;
                Debug.WriteLine("{0} datetime: {1}", file, str);
                if (str != null)
                {
                    datetime = str.Split(' ')[0].Replace(':', '/');
                }
            }
            var text = getFrontCaption() + datetime + getBackCaption();
            Debug.WriteLine("{0} text: {1}", file, text);

            Size size = TextRenderer.MeasureText(text, font);
            int childWidth = size.Width;
            int childHeight = size.Height;
            Debug.WriteLine("MeasureText size: {0},{1}", size.Width, size.Height);

            Point point = calcCoordinate(width, height, childWidth, childHeight);
            var styleMap = new Dictionary<FontStyle, FontStyleType>()
            {
                [FontStyle.Regular] = FontStyleType.Normal,
                [FontStyle.Bold] = FontStyleType.Bold,
                [FontStyle.Italic] = FontStyleType.Italic,
                [FontStyle.Underline] = FontStyleType.Normal,
                [FontStyle.Strikeout] = FontStyleType.Normal,
            };
            var weightMap = new Dictionary<FontStyle, FontWeight>()
            {
                [FontStyle.Regular] = FontWeight.Normal,
                [FontStyle.Bold] = FontWeight.Bold,
                [FontStyle.Italic] = FontWeight.Normal,
                [FontStyle.Underline] = FontWeight.Normal,
                [FontStyle.Strikeout] = FontWeight.Normal,
            };

            inputImage.Settings.FontFamily = font.Name;
            inputImage.Settings.Font = font.Name;
            inputImage.Settings.FontPointsize = font.Size;
            inputImage.Settings.FontStyle = styleMap[font.Style];
            inputImage.Settings.FontWeight = weightMap[font.Style];
            inputImage.Settings.FillColor = MagickColors.Yellow;
            inputImage.Settings.AntiAlias = true;
            var geo = new MagickGeometry(point.X, point.Y, 0, 0);
            inputImage.Annotate(text, geo);

            // Save to the new file
            string outputFile = "Output_" + Path.GetFileNameWithoutExtension(file) + ".jpg";
            string outputPath = Path.Combine(Path.GetDirectoryName(file), outputFile);
            inputImage.Quality = 75;
            inputImage.Write(outputPath);
            Debug.WriteLine("{0}:handle end, output:{1}", file, outputPath);
            return true;
        }

        // 获取前段内容
        private string getFrontCaption()
        {
            return textBoxFront.Text;
        }

        // 获取后段内容
        private string getBackCaption()
        {
            return textBoxBack.Text;
        }

        // 获取文本放置角落
        private CornType getCornType()
        {
            return (CornType)comboBoxCorner.SelectedIndex;
        }

        // 计算子元素的坐标
        private Point calcCoordinate(int width, int height, int childWidth, int childHeight)
        {
            Point p = new Point();
            int x = 0;
            int y = 0;

            switch (getCornType())
            {
                case CornType.TopLeft:
                    x = width * 1 / 24;
                    y = height * 1 / 32;
                    break;

                case CornType.TopCenter:
                    x = (width - childWidth) / 2;
                    y = height * 1 / 32;
                    break;

                case CornType.TopRight:
                    x = width - childWidth - width * 1 / 24;
                    y = height * 1 / 32;
                    break;

                case CornType.BottomLeft:
                    x = width * 1 / 24;
                    y = height * 31 / 32;
                    break;

                case CornType.BottomCenter:
                    x = (width - childWidth) / 2;
                    y = height * 31 / 32;
                    break;

                case CornType.BottomRight:
                    x = width - childWidth - width * 1 / 24;
                    y = height * 31 / 32;
                    break;

                default:
                    x = width * 1 / 24;
                    y = height * 31 / 32;
                    break;
            }

            p.X = x;
            p.Y = y;
            return p;
        }

        // 打印字节码
        private void printEncode(string s)
        {
            byte[] bytes = Encoding.Default.GetBytes(s);
            Debug.WriteLine(BitConverter.ToString(bytes));
        }


        private string[]? filePaths;
        private Dictionary<string, HandleImage>? typeMap;
        private Font font;


    }
    delegate bool HandleImage(string file);
}
