using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Infoearth.Solution.AutoDeploy.Utility.Install;
using System.IO;

namespace Infoearth.Solution.AutoDeploy.Utility.UI
{
    public partial class EnvInstaller : UserControl
    {
        private MyInstaller _installer = null;
        private BackgroundWorker _installerBGWorker = new BackgroundWorker();
        /// <summary>
        /// 安装包路径
        /// </summary>
        private string _installPackager = string.Empty;


        public EnvInstaller(string installPackager)
        {
            InitializeComponent();

            toolTip1.SetToolTip(picInstall, "安装");

            if (File.Exists(installPackager))
            {
                label1.Text = Path.GetFileName(installPackager);
                _installerBGWorker.WorkerReportsProgress = true;
                _installerBGWorker.WorkerSupportsCancellation = true;
                _installerBGWorker.DoWork += _installerBGWorker_DoWork;
                _installerBGWorker.RunWorkerCompleted += _installerBGWorker_RunWorkerCompleted;
                _installerBGWorker.ProgressChanged += _installerBGWorker_ProgressChanged;
                _installPackager = installPackager;
            }
            else
            {
                label1.Text = "安装包路径异常..";
                label1.ForeColor = Color.Red;
                picInstall.Enabled = false;
            }
        }
       
        private void picInstall_Click(object sender, EventArgs e)
        {
            if (!_installerBGWorker.IsBusy)
            {
                picInstall.Enabled = false;
                CancelButton.Visible = true;
                label2.Visible = true;
                progressBar1.Visible = true;
                _installerBGWorker.RunWorkerAsync();
            }
        }

        private void _installerBGWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            // 消息通过 e.UserState 传回，并通过label显示在窗口上
            string message = e.UserState.ToString();
            this.label2.Text = message;
            if (message == "正在取消安装 ...")
            {
                this.CancelButton.Enabled = false;
            }
        }

        private void _installerBGWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            // 安装过程结束
            this.label2.Text = "安装完成";
            CancelButton.Visible = false;
            label2.Visible = false;
            progressBar1.Visible = false;
            picInstall.Enabled = true;
        }

        private void _installerBGWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker bgWorker = sender as BackgroundWorker;

            // 开始执行安装方法
            _installer = new MyInstaller();
            _installer.Install(bgWorker, _installPackager);
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            _installer.Canceled = true;
            _installerBGWorker.CancelAsync();
        }
    }
}
