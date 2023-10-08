using System.Text;
using Path = System.IO.Path;
using ImageMagick;
using System.Diagnostics;
using System.Drawing.Imaging;
using System.ComponentModel;

namespace monkey_image
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            SetDefaultAttrComponent();
            InitializeBackgroundWorker();
            InitializeTypeMap();
            Log.WriteLine("MonkeyImage Start");
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

        public const int ExifDTOriginalId = 0x9003;

        // 设置组件的默认属性
        private void SetDefaultAttrComponent()
        {
            comboBoxCorner.SelectedIndex = 3; //底部左边
            font = new Font("Arial", 120, FontStyle.Bold);
            textBoxFont.Text = font.ToString();
        }

        // 注册后台任务相关函数
        private void InitializeBackgroundWorker()
        {
            bgWorker.DoWork += new DoWorkEventHandler(bgWorker_DoWork);
            bgWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bgWorker_Completed);
            bgWorker.ProgressChanged += new ProgressChangedEventHandler(bgWorker_ProgressChanged);
        }

        private void InitializeTypeMap()
        {
            typeMap = new Dictionary<string, HandleImage>(){
                {".jpg", handleGeneral},
                {".jpeg", handleGeneral},
                {".png", handleGeneral},
                {".heic", handleGeneral}
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
            Debug.WriteLine("processing start, num:{0}", filePaths.Length);
            Log.WriteLine("processing start, num:{0}", filePaths.Length);

            readSetting();

            textBoxDir.Enabled = false;
            buttonOpen.Enabled = false;
            groupBoxText.Enabled = false;
            groupBoxGraph.Enabled = false;
            groupBoxFont.Enabled = false;
            buttonAbout.Enabled = false;
            buttonStart.Enabled = false;

            toolStripProgressBar.Minimum = 0;
            toolStripProgressBar.Maximum = filePaths.Length;
            toolStripProgressBar.Value = 0;
            toolStripProgressBar.Step = 1;

            bgWorker.RunWorkerAsync(filePaths.Length);
        }

        private void buttonAbout_Click(object sender, EventArgs e)
        {
            string appProper = string.Format("Monkey Image\nVersion: {0}\nAuthor: {1}",
                "v1.0.0", "houshidi@sina.com");
            MessageBox.Show(appProper, "关于");
        }

        private void buttonFont_Click(object sender, EventArgs e)
        {
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                font = fontDialog.Font;
                textBoxFont.Text = font.ToString();
            }
        }

        private void bgWorker_DoWork(object? sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;

            Debug.WriteLine("bgWorker_DoWork");
            e.Result = handleImages(worker, e);
        }

        private void bgWorker_ProgressChanged(object? sender, ProgressChangedEventArgs e)
        {
            toolStripProgressBar.PerformStep();
            int value = toolStripProgressBar.Value;
            int max = toolStripProgressBar.Maximum;
            Debug.WriteLine("bgWorker_ProgressChanged, progress:{0}/{1}", value, max);
            Log.WriteLine("bgWorker_ProgressChanged, progress:{0}/{1}", value, max);
        }

        private void bgWorker_Completed(object? sender, RunWorkerCompletedEventArgs e)
        {
            Debug.WriteLine("bgWorker_Completed");

            textBoxDir.Enabled = true;
            buttonOpen.Enabled = true;
            groupBoxText.Enabled = true;
            groupBoxGraph.Enabled = true;
            groupBoxFont.Enabled = true;
            buttonAbout.Enabled = true;
            buttonStart.Enabled = true;

            Debug.WriteLine("processing end: "+e.Result);
            Log.WriteLine("processing end: " + e.Result);
        }

        private bool handleImages(BackgroundWorker worker, DoWorkEventArgs e)
        {
            bool ok = true;
            int n = 0;

            if (filePaths == null || filePaths.Length == 0 )
            {
                return false;
            }

            foreach (var one in filePaths)
            {
                var res = handleImageEntry(one);
                if (res == false)
                {
                    ok = false;
                    Debug.WriteLine("processing failed", one);
                }
                n++;
                worker.ReportProgress(n);
            }

            return ok;
        }

        // 处理图片入口
        private bool handleImageEntry(string file)
        {
            var ext = Path.GetExtension(file).ToLower();
            if (typeMap != null && typeMap.ContainsKey(ext))
            {
                var h = typeMap[ext];
                if (h != null)
                {
                    return h(file);
                }
            }
            return true;
        }

        private bool handleGeneral(string file)
        {
            string datetime = DateTime.Now.ToString("yyyy/MM/dd");

            Debug.WriteLine("handleGeneral:" + file);
            using MagickImage inputImage = new MagickImage(file);
            if (inputImage == null)
            {
                Debug.WriteLine("open file failed:" + file);
                Log.WriteLine("open file failed:" + file);
                return false;
            }

            using Bitmap inputBitMap = inputImage.ToBitmap(ImageFormat.Jpeg);

            // 绘制文字
            if (needDrawText)
            {
                PropertyItem? prop;
                prop = getPropertyItem(inputBitMap, ExifDTOriginalId);
                if (prop != null && prop.Value != null)
                {
                    datetime = Encoding.Default.GetString(prop.Value).Trim('\0');
                    Debug.WriteLine("{0} datetime: {1}", file, datetime);
                    datetime = datetime.Split(' ')[0].Replace(':', '/');
                }
                var text = frontText + datetime + backText;
                Debug.WriteLine("{0} text: {1}", file, text);

                // 获取图像宽度和高度
                int width = inputBitMap.Width;
                int height = inputBitMap.Height;
                Size size = TextRenderer.MeasureText(text, font);
                int childWidth = size.Width;
                int childHeight = size.Height;
                Debug.WriteLine("MeasureText size: {0},{1}", size.Width, size.Height);
                Point point = calcCoordinate(width, height, childWidth, childHeight);

                // 设置字体和颜色
                SolidBrush brush = new SolidBrush(Color.Yellow);

                using Graphics inputGraph = Graphics.FromImage(inputBitMap);
                inputGraph.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                inputGraph.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                var rect = new Rectangle(point.X, point.Y, childWidth, childHeight);
                var drawFormat = new StringFormat();
                drawFormat.Alignment = StringAlignment.Center;
                drawFormat.LineAlignment = StringAlignment.Center;
                inputGraph.DrawString(text, font, brush, rect, drawFormat);
            }
            // 创建编码器
            ImageCodecInfo jpgEncoder = GetEncoder(ImageFormat.Jpeg);
            System.Drawing.Imaging.Encoder encoder = System.Drawing.Imaging.Encoder.Quality;
            EncoderParameters enParams = new EncoderParameters(1);
            EncoderParameter enParam = new EncoderParameter(encoder, quality);
            enParams.Param[0] = enParam;

            // 保存修改后的图像到磁盘
            string outputFile = string.Format("Output_{0}_{1}.{2}",
                (int)cornType, Path.GetFileNameWithoutExtension(file), "jpg");
            string outputPath = Path.Combine(Path.GetDirectoryName(file), outputFile);
            inputBitMap.Save(outputPath, jpgEncoder, enParams);

            Debug.WriteLine("{0}:handle end, output:{1}", file, outputPath);
            return true;
        }

        private PropertyItem? getPropertyItem(Bitmap b, int id)
        {
            PropertyItem? prop;
            try
            {
                prop = b.GetPropertyItem(id);
                return prop;
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"{ex.Message}");
            }
            return null;
        }

        private ImageCodecInfo GetEncoder(ImageFormat format)
        {
            ImageCodecInfo[] codecs = ImageCodecInfo.GetImageEncoders();
            foreach (ImageCodecInfo codec in codecs)
            {
                if (codec.FormatID == format.Guid)
                {
                    return codec;
                }
            }
            return null;
        }

        // 计算子元素的坐标
        private Point calcCoordinate(int width, int height, int childWidth, int childHeight)
        {
            int x;
            int y;
            Point p = new Point();

            switch (cornType)
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
                    y = height * 30 / 32;
                    break;

                case CornType.BottomCenter:
                    x = (width - childWidth) / 2;
                    y = height * 30 / 32;
                    break;

                case CornType.BottomRight:
                    x = width - childWidth - width * 1 / 24;
                    y = height * 30 / 32;
                    break;

                default:
                    x = width * 1 / 24;
                    y = height * 30 / 32;
                    break;
            }

            p.X = x;
            p.Y = y;
            return p;
        }

        private void readSetting()
        {
            frontText = textBoxFront.Text;
            backText = textBoxBack.Text;
            cornType = (CornType)comboBoxCorner.SelectedIndex;
            quality = (int)numericQuality.Value;
            needDrawText = checkBoxDrawText.Checked;
            if (quality < numericQuality.Minimum || quality > numericQuality.Maximum)
            {
                quality = 80; //default
            }
        }

        private string[]? filePaths;
        private Dictionary<string, HandleImage>? typeMap;
        private Font font;

        /// <summary> 前段文本 </summary>
        private string frontText;

        /// <summary> 后段文本 </summary>
        private string backText;

        /// <summary> 角落类型 </summary>
        private CornType cornType;

        /// <summary> 转换质量 </summary>
        private int quality;

        /// <summary> 是否绘制文本 </summary>
        private bool needDrawText;

    }
    delegate bool HandleImage(string file);
}
