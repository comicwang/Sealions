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
    public partial class FormProject : Form
    {
        public FormProject()
        {
            InitializeComponent();
        }

        public FormProject(ProjectInfo projectInfo) : this()
        {
            this.Text = $"Sealion-{projectInfo.Name}";
            this.bindingSource1.DataSource = projectInfo;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //项目信息
            ProjectInfo projectInfo = new ProjectInfo();
            projectInfo.Id = textBox1.Tag?.ToString();
            projectInfo.Name = textBox1.Text;
            projectInfo.prjSystem = textBox2.Text;
            projectInfo.Publisher = textBox4.Text;
            projectInfo.Version = textBox3.Text;
            projectInfo.PublishDate = dateTimePicker1.Value;
            var opration = new OprateBase<ProjectInfo>();
            opration.Save(projectInfo);

            DialogResult = DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
