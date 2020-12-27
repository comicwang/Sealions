using Sealion.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Deployment.Builder
{
    public partial class FormPackage : Form
    {
        private ProjectInfo prjInfo = null;
        private PackageInfo package = null;

        public FormPackage(ProjectInfo projectInfo)
        {
            InitializeComponent();
            textBox1.Text = projectInfo.Name;
            prjInfo = projectInfo;
        }

        public FormPackage(PackageInfo packageInfo) : this(packageInfo.prjInfo)
        {
            this.Text = $"Sealion-{packageInfo.Name}";
            this.textBox2.Text = packageInfo.Name;
            switch (packageInfo.PType)
            {
                case PackageType.IIS:
                    checkBox1.Checked = true;
                    break;                  
                case PackageType.Backage:
                    checkBox2.Checked = true;
                    break;
                case PackageType.Sql:
                    checkBox3.Checked = true;
                    break;
                default:
                    break;
            }
            package = packageInfo;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (package == null)
            {
                package = new PackageInfo();
                package.Id = Guid.NewGuid().ToString();
            }
            package.prjInfo = prjInfo;
            package.Name = textBox2.Text;
            if (checkBox1.Checked)
            {
                package.PType = PackageType.IIS;
            }
            else if (checkBox2.Checked)
            {
                package.PType = PackageType.Backage;
            }
            else if (checkBox3.Checked)
            {
                package.PType = PackageType.Sql;
            }
            var oprate = new OprateBase<PackageInfo>();
            oprate.Save(package);
            DialogResult = DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
