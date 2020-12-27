using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Deployment.Builder.Controller
{
    public partial class SuperPanel : UserControl
    {
        /// <summary>
        /// 隐藏控件事件
        /// </summary>
        public event EventHandler HidePanel;

        public SuperPanel()
        {
            InitializeComponent();          
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }

        private void btnHidden_Click(object sender, EventArgs e)
        {
            if (HidePanel != null)
            {
                HidePanel(sender, e);
            }
            this.Hide();
        }

        /// <summary>
        /// 主Panel
        /// </summary>
        public Panel Body { get { return this.pnlMain; } }

        public bool Closeable { get { return btnClose.Visible; } set { btnClose.Visible = value; } }

        public bool Hidenable { get { return btnHidden.Visible; } set { btnHidden.Visible = value; } }

        public string PanelName { get { return label1.Text; } set { label1.Text = value; } }
    }
}
