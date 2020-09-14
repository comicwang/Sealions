using Infoearth.Solution.AutoDeploy.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Infoearth.Solution.AutoDeploy.Utility.UI
{
    public partial class FormLoadGlobal : Form
    {
        private string _configPath = string.Empty;

        public FormLoadGlobal(string configPath)
        {
            InitializeComponent();
            _configPath = configPath;
            LoadUI(configPath);
        }

        /// <summary>
        /// 加载UI
        /// </summary>
        /// <param name="filePath"></param>
        private void LoadUI(string filePath)
        {
            ConfigReader configReader = new ConfigReader(filePath);
            Dictionary<string, string> dic = configReader.ReadConfig(ConfigType.appSettings.ToString(), string.Empty);

            foreach (KeyValuePair<string, string> kv in dic)
            {
                KeyValueUI kvUi = new KeyValueUI();
                kvUi.Dock = DockStyle.Top;
                kvUi.ShowUsed = true;
                kvUi.UKey = kv.Key;
                kvUi.UValue = kv.Value;
                panel1.Controls.Add(kvUi);
            }
        }

        /// <summary>
        /// 选中的配置节
        /// </summary>
        public List<ConfigData> SelectedData = new List<ConfigData>();

        private void btnOk_Click(object sender, EventArgs e)
        {
            foreach (Control ctl in panel1.Controls)
            {
                KeyValueUI kvUi = ctl as KeyValueUI;
                if (kvUi.Used)
                {
                    SelectedData.Add(new ConfigData()
                    {
                        ConfigPath = _configPath,
                        KeyVal = kvUi.UKey,
                        ValueVal = kvUi.UValue,
                        TypeVal = ConfigType.appSettings
                    });
                }
            }
            DialogResult = DialogResult.OK;
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            foreach (Control ctl in panel1.Controls)
            {
                KeyValueUI kvUi = ctl as KeyValueUI;
                kvUi.Used = !kvUi.Used;
            }
        }
    }
}
