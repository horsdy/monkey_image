using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Path = System.IO.Path;

namespace monkey_image
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            InitializeTypeMap();
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
            else
            {
                filePaths = null;
                textBoxDir.Text = null;
            }
        }


        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (filePaths.Length == 0)
            {
                return;
            }
            Console.WriteLine("processing start");
            foreach (var one in filePaths)
            {
                // TODO 使用协程池
                var res = handleImageEntry(one);
                if (res == false)
                {
                    Console.WriteLine("processing {0} failed", one);
                }
            }

            Console.WriteLine("processing end");
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

        private void InitializeTypeMap()
        {
            typeMap = new Dictionary<string, HandleImage>(){
                {".jpg", handleJpg},
                {".jpeg", handleJpg},
                {".heic", handleHeic}
            };
        }

        private bool handleJpg(string file)
        {
            string datetime = DateTime.Now.ToString("yyyy/MM/dd");
            Console.WriteLine("handleJpg");

            Bitmap fileBitMap = new Bitmap(file);
            var prop = fileBitMap.GetPropertyItem(0x9003);
            if (prop != null) {
                datetime = Encoding.Default.GetString(prop.Value).Trim('\0');
                Console.WriteLine("{0} datetime: {1}", file, datetime);
                datetime = datetime.Split(' ')[0].Replace(':', '/');
            }

            // 设置字体和颜色
            Font font = new Font("Arial", 80, FontStyle.Bold);
            SolidBrush brush = new SolidBrush(Color.Yellow);

            // 获取图像宽度和高度
            int width = fileBitMap.Width;
            int height = fileBitMap.Height;

            // 计算元数据区域的宽度和高度
            int metaWidth = width / 2;
            int metaHeight = height / 10;

            // 创建元数据区域
            Bitmap metaBitmap = new Bitmap(metaWidth, metaHeight);

            // 在元数据区域中绘制文本框
            Graphics metaGraph = Graphics.FromImage(metaBitmap);
            metaGraph.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            metaGraph.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            metaGraph.DrawString(datetime, font, brush, new Rectangle(0, 0, metaWidth, metaHeight));

            // 将元数据区域合并到主图像上
            Graphics fileGraph = Graphics.FromImage(fileBitMap);
            fileGraph.DrawImage(metaBitmap, new Rectangle(width/16, (int)(height *0.95), metaWidth, metaHeight));

            // 保存修改后的图像到磁盘
            string outputPath = Path.Combine(Path.GetDirectoryName(file), "Output_" + Path.GetFileNameWithoutExtension(file) + ".jpg");
            fileBitMap.Save(outputPath);

            metaGraph.Dispose();
            fileGraph.Dispose();
            metaBitmap.Dispose();
            fileBitMap.Dispose();
            return true;
        }

        private bool handleHeic(string file)
        {
            Console.WriteLine("handleHeic");

            return true;
        }

        private string[] filePaths;
        private Dictionary<string, HandleImage> typeMap;
    }
    delegate bool HandleImage(string file);
}
