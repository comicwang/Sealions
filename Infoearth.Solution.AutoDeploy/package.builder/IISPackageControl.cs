using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using package.builder.main;
using Sealion.Model;
using System.IO;
using Sealions.Core.Files;

namespace package.builder
{
    public partial class IISPackageControl : UserControl
    {
        private PackageInfo _packageInfo = null;

        private IISPackageControl()
        {
            InitializeComponent();
        }

        public IISPackageControl(PackageInfo packageInfo) : this()
        {
            _packageInfo = packageInfo;
        }

        private void 导入包ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (DialogResult.OK == folderBrowserDialog.ShowDialog())
            {
                string selectPath = folderBrowserDialog.SelectedPath;
                string prjPath = Path.Combine(Application.StartupPath, "Data", _packageInfo.VirturePath);
                selectPath.CopyDir(prjPath);
                this.treeView1.ClearBindDir();
                this.treeView1.BindDir(prjPath);
            }
        }

    }
}
