using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Infoearth.Solution.AutoDeploy.Utility.UI
{
    public partial class KeyValueUI : UserControl
    {
        public KeyValueUI()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 键名称
        /// </summary>
        public string UKey
        {
            get { return lblKey.Text; }
            set { lblKey.Text = value; }
        }

        /// <summary>
        /// 值名称
        /// </summary>
        public string UValue
        {
            get { return txtValue.Text; }
            set { txtValue.Text = value; }
        }

        /// <summary>
        /// 是否显示状态可用
        /// </summary>
        public bool ShowUsed
        {
            get { return ckUsed.Visible; }
            set { ckUsed.Visible = value; }
        }

        /// <summary>
        /// 是否产生效果
        /// </summary>
        public bool Used
        {
            get { return ckUsed.Checked; }
            set { ckUsed.Checked = value; txtValue.Enabled = value; }
        }

        /// <summary>
        /// 值变化事件
        /// </summary>
        public event EventHandler OnChanged;

        private void txtValue_TextChanged(object sender, EventArgs e)
        {
            if (OnChanged != null)
            {
                OnChanged(sender, e);
            }
        }

        private void ckUsed_CheckedChanged(object sender, EventArgs e)
        {
            txtValue.Enabled = ckUsed.Checked;
        }
    }
}
