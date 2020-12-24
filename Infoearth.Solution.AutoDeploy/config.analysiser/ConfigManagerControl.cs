using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sealions.Core.Files;
using System.IO;

namespace config.analysiser
{
    public partial class ConfigManagerControl : UserControl
    {
        private ConfigManagerControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="filePath"></param>
        public ConfigManagerControl(string filePath) : this()
        {
            //是否为压缩文件
            FileOrDirInfo fileOrDirInfo = new FileOrDirInfo(filePath);
            if (fileOrDirInfo.IsFile)
            {
                string tempDir = Path.Combine(Path.GetTempPath(), "Selions", DateTime.Now.ToFileTimeUtc().ToString());
                if (Directory.Exists(tempDir))
                {
                    Directory.CreateDirectory(tempDir);
                }
                bool invalid = fileOrDirInfo.Ext.ToLower().EndsWith(".zip");
                if (invalid == false)
                {
                    Console.WriteLine("压缩文件路径或者格式不合法");
                }
                else
                {
                    //解压缩文件
                }

            }
        }

        private void ConfigManagerControl_Load(object sender, EventArgs e)
        {

        }
    }
}
