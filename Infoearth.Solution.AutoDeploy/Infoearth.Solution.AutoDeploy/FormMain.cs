using Infoearth.Solution.AutoDeploy.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Infoearth.Solution.AutoDeploy.Model;
using Infoearth.Solution.AutoDeploy.Utility.UI;
using Infoearth.Solution.AutoDeploy.Utility.Install;
using Sealions.Core.Files;

namespace Infoearth.Solution.AutoDeploy
{
    public partial class FormMain : Form
    {
        private string PublishDir = string.Empty;

        private List<TabPage> _addPages = new List<TabPage>();

        private List<DeployData> _dataSource = new List<DeployData>();

        private static string Global_Xml = Path.Combine(Application.StartupPath, "Config", "Global.xml");

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            propertyGrid1.SelectedObject = new LocalEnvironment();
            for (int i = 0; i < cklsbFilter.Items.Count; i++)
            {
                cklsbFilter.SetItemChecked(i, true);
            }
            LoadGlobal();
            treeView1.BindDir(@"E:\GeologicHazardMonitoring_Product_V2.1");
        }

        private void LoadPackageInstall()
        {
            this.enviromentPnl.Controls.Clear();
            string[] installers = Directory.GetFiles(txtRoot.Text, "*.*").Where(t => t.ToLower().EndsWith(".msi") || t.ToLower().EndsWith(".exe")).ToArray();
            foreach (string item in installers)
            {
                EnvInstaller install = new EnvInstaller(item);
                install.Dock = DockStyle.Top;
                this.enviromentPnl.Controls.Add(install);
            }
        }

        private void txtRoot_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            FolderBrowserDialog folderDialog = new FolderBrowserDialog();
            folderDialog.RootFolder = Environment.SpecialFolder.DesktopDirectory | Environment.SpecialFolder.MyComputer;
            if (folderDialog.ShowDialog() == DialogResult.OK)
            {
                txtRoot.Text = folderDialog.SelectedPath;
                btnLoad_Click(sender, e);
            }
        }

        private void txtRoot_TextChanged(object sender, EventArgs e)
        {
            btnLoad.Enabled = !string.IsNullOrEmpty(txtRoot.Text) && Directory.Exists(txtRoot.Text);
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            _dataSource.Clear();

            string[] lst = Directory.GetDirectories(txtRoot.Text);
            
            foreach (string dir in lst)
            {
                _dataSource.Add(new DeployData()
                {
                    Deploy = false,
                    Dirctory = dir,
                    WebName = Path.GetFileName(dir)
                });
            }
            deployDataBindingSource.DataSource = _dataSource;

            LoadPackageInstall();
        }

        #region 筛选内容

        private string PercharHold = "输入名称按【Enter】过滤";

        private void txtFilter_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFilter.Text))
            {
                txtFilter.Text = PercharHold;
            }
        }

        private void txtFilter_Enter(object sender, EventArgs e)
        {
            if (txtFilter.Text == PercharHold)
            {
                txtFilter.Text = string.Empty;
            }
        }

        private void txtFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                List<DeployData> data = _dataSource.Where(t => t.WebName.Contains(txtFilter.Text.Trim())).ToList();
                deployDataBindingSource.DataSource = data;
            }
        }

        #endregion

        #region 全选清除

        private void button4_Click(object sender, EventArgs e)
        {
            deployDataBindingSource.DataSource = new List<DeployData>();
            _dataSource.Clear();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.Cells[0].Value = !(bool)row.Cells[0].Value;
            }
        }


        #endregion

        #region 筛选选项

        private void btnAddFilter_Click(object sender, EventArgs e)
        {
            FormAddKeyVal form = new FormAddKeyVal("新增筛选文件");
            if (form.ShowDialog() == DialogResult.OK)
            {
                cklsbFilter.Items.Add(form.Value);
                cklsbFilter.SetItemChecked(cklsbFilter.Items.Count - 1, true);
            }
        }

        private void btnClearFilter_Click(object sender, EventArgs e)
        {
            cklsbFilter.Items.Clear();
        }

        #endregion

        #region 导入配置项

        private void btnImport_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();

            foreach (TabPage tab in _addPages)
            {
                tabControls.TabPages.Remove(tab);
            }

            List<DeployData> lstDeployData = deployDataBindingSource.DataSource as List<DeployData>;

            List<ConfigData> lstGlobalData = GetGlobalData();

            foreach (DeployData deployData in lstDeployData)
            {
                List<ConfigData> lstConfigData = new List<ConfigData>();

                if (deployData.Deploy)
                {
                    List<string> lstConfigFiles = new List<string>();
                    //搜索标识
                    foreach (var opt in cklsbFilter.CheckedItems)
                    {
                        string[] files = Directory.GetFiles(deployData.Dirctory, opt.ToString());
                        lstConfigFiles.AddRange(files);
                    }

                    foreach (string filePath in lstConfigFiles)
                    {
                        ConfigReader configReader = new ConfigReader(filePath);
                        Dictionary<string, string> dic = configReader.ReadConfig(ConfigType.appSettings.ToString(), string.Empty);

                        foreach (KeyValuePair<string, string> kv in dic)
                        {
                            if (!lstGlobalData.Where(t => t.KeyVal == kv.Key).Any())
                            {
                                lstConfigData.Add(new ConfigData()
                                {
                                    ConfigPath = filePath,
                                    KeyVal = kv.Key,
                                    ValueVal = kv.Value,
                                    WebName = deployData.WebName,
                                    TypeVal = ConfigType.appSettings
                                });
                            }
                        }
                    }

                    if (lstConfigData.Count > 0)
                    {
                        //加配置文件
                        TabPage tabPage = new TabPage(deployData.WebName);
                        Panel gp = new Panel();
                        gp.Dock = DockStyle.Fill;
                        gp.AutoScroll = true;
                        int height = 0;
                        foreach (var item in lstConfigData)
                        {
                            KeyValueUI kvUi = new KeyValueUI();
                            kvUi.Dock = DockStyle.Top;
                            kvUi.UKey = item.KeyVal;
                            kvUi.UValue = item.ValueVal;
                            gp.Controls.Add(kvUi);
                            height += kvUi.Height;
                        }
                        gp.Height = height + 30;
                        tabPage.Controls.Add(gp);
                        tabControls.TabPages.Add(tabPage);
                        _addPages.Add(tabPage);
                    }
                }
            }
        }

        #endregion

        #region 全局设置

        /// <summary>
        /// 加载全局设置
        /// </summary>
        private void LoadGlobal()
        {
            if (File.Exists(Global_Xml))
            {
                List<ConfigData> lstConfigs = XmlSerializion.DeSerializion<List<ConfigData>>(Global_Xml);

                pnlGlobal.Controls.Clear();

                foreach (ConfigData item in lstConfigs)
                {
                    AddGlobalUI(item);
                }
            }
            else if (Directory.Exists(Path.Combine(Application.StartupPath, "Config")) == false)
            {
                Directory.CreateDirectory(Path.Combine(Application.StartupPath, "Config"));
            }
        }

        private void AddGlobalUI(ConfigData configData)
        {
            KeyValueUI kvUi = new KeyValueUI();
            kvUi.Dock = DockStyle.Top;
            kvUi.UKey = configData.KeyVal;
            kvUi.UValue = configData.ValueVal;
            kvUi.OnChanged += KvUi_OnChanged;
            pnlGlobal.Controls.Add(kvUi);
        }

        private void KvUi_OnChanged(object sender, EventArgs e)
        {          
            XmlSerializion.Seralize(GetGlobalData(), Global_Xml);
        }

        /// <summary>
        /// 获取全局数据
        /// </summary>
        /// <returns></returns>
        private List<ConfigData> GetGlobalData()
        {
            List<ConfigData> lstConfigs = new List<ConfigData>();

            foreach (Control ctl in pnlGlobal.Controls)
            {
                KeyValueUI kvUi = ctl as KeyValueUI;
                lstConfigs.Add(new ConfigData()
                {
                    ConfigPath = Global_Xml,
                    KeyVal = kvUi.UKey,
                    ValueVal = kvUi.UValue,
                    TypeVal = ConfigType.appSettings
                });
            }

            return lstConfigs;
        }

        private void lklblLoalGlobal_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "配置文件|*.config";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                FormLoadGlobal form = new FormLoadGlobal(dialog.FileName);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    List<ConfigData> lstConfig = form.SelectedData;
                    XmlSerializion.Seralize(lstConfig, Global_Xml);
                    LoadGlobal();
                }
            }
        }

        private void lklblClearGlobal_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            File.Delete(Global_Xml);
            pnlGlobal.Controls.Clear();
        }

        private void lklblAddGlobal_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormAddKeyVal formKv = new FormAddKeyVal("新增全局配置节点");
            if (formKv.ShowDialog() == DialogResult.OK)
            {
                Dictionary<string, string> kvs = formKv.KeyValue;

                if (kvs.Count > 0)
                {
                    List<ConfigData> lstConfigs = XmlSerializion.DeSerializion<List<ConfigData>>(Global_Xml) ?? new List<ConfigData>();
                    foreach (KeyValuePair<string, string> kv in kvs)
                    {
                        ConfigData configData = new ConfigData()
                        {
                            ConfigPath = Global_Xml,
                            KeyVal = kv.Key,
                            ValueVal = kv.Value,
                            TypeVal = ConfigType.appSettings
                        };
                        lstConfigs.Add(configData);
                        AddGlobalUI(configData);
                    }
                    XmlSerializion.Seralize(lstConfigs, Global_Xml);
                }
            }
        }

        #endregion

    }
}
