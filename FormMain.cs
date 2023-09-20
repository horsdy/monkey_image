using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            Console.WriteLine("handleJpg");

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
