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
    public partial class FormAddKeyVal : Form
    {
        public FormAddKeyVal(string title)
        {
            InitializeComponent();
            this.Text = title;
        }

        /// <summary>
        /// 值
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        /// 值键
        /// </summary>
        public Dictionary<string, string> KeyValue = new Dictionary<string, string>();

        private void btnOk_Click(object sender, EventArgs e)
        {
            Value = txtVal.Text;
            string[] kvs = txtVal.Lines;
            for (int i = 0; i < kvs.Length; i++)
            {
                if (i % 2 == 0)
                {
                    if (!string.IsNullOrEmpty(kvs[i]))
                        KeyValue.Add(kvs[i], (i + 1) < kvs.Length ? kvs[i + 1] : string.Empty);
                }
            }
            DialogResult = DialogResult.OK;
        }
    }
}
