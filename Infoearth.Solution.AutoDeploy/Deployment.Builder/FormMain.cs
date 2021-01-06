using package.builder;
using Sealion.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Deployment.Builder
{
    public partial class FormMain : Form
    {
        private TreeView treeView = new TreeView();

        public FormMain()
        {
            InitializeComponent();
        }

        private void 新建项目ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormProject formCreateProject = new FormProject();
            DialogResult dialogResult = formCreateProject.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                IniTree();
            }
        }

        private void 打开项目ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IniPackage(treeView.SelectedNode);
        }

        private void 编辑项目ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProjectInfo projectInfo = treeView.SelectedNode.Tag as ProjectInfo;
            FormProject formCreateProject = new FormProject(projectInfo);
            DialogResult dialogResult = formCreateProject.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                IniTree();
            }
        }

        private void 删除项目ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ProjectInfo projectInfo = treeView.SelectedNode.Tag as ProjectInfo;
            var oprate = new OprateBase<ProjectInfo>();
            oprate.Delete(projectInfo);
            IniTree();
        }

        private void 新建包ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ProjectInfo projectInfo = treeView.SelectedNode.Tag as ProjectInfo;
            FormPackage formPackage = new FormPackage(projectInfo);
            if (DialogResult.OK == formPackage.ShowDialog())
            {
                IniPackage(treeView.SelectedNode);
            }
        }

        private void superPanel1_Load(object sender, EventArgs e)
        {
            treeView.Dock = DockStyle.Fill;
            treeView.NodeMouseDoubleClick += TreeView_NodeMouseDoubleClick;
            superPanel1.Body.Controls.Add(treeView);
            IniTree();
        }

        private void TreeView_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            //打开项目包
            if (e.Node.Level == 0)
            {
                IniPackage(e.Node);
                e.Node.ExpandAll();
            }
            //打开包信息
            else if (e.Node.Level == 1)
            {
                EditPackage(e.Node.Tag as PackageInfo);
            }
        }

        /// <summary>
        /// 初始化包
        /// </summary>
        /// <param name="node"></param>
        private void IniPackage(TreeNode node)
        {
            var prjInfo = node.Tag as ProjectInfo;
            var oprate = new OprateBase<PackageInfo>();
            var pckInfo = oprate.GetList(prjInfo);
            node.Nodes.Clear();
            listView1.Items.Clear();
            foreach (var item in pckInfo)
            {
                TreeNode temp = new TreeNode(item.Name);
                temp.Tag = item;
                temp.Name = item.Id;
                temp.ContextMenuStrip = ctxtPackage;
                node.Nodes.Add(temp);
                ListViewItem listViewItem = new ListViewItem();
                listViewItem.Text = item.Name;
                listViewItem.Tag = item;
                listViewItem.ImageIndex = 0;
                listView1.Items.Add(listViewItem);
            }
            tslPrj.Text = $"{pckInfo.Count}个包";
            tslPackage.Visible = true;
            tslPackage.Text = prjInfo.Name;


        }

        /// <summary>
        /// 初始化项目树
        /// </summary>
        private void IniTree()
        {
            var oprate = new OprateBase<ProjectInfo>();
            var result = oprate.GetList(ModelSimple.Instance);
            treeView.Nodes.Clear();
            foreach (var item in result)
            {
                TreeNode temp = new TreeNode(item.Name);
                temp.Tag = item;
                temp.Name = item.Id;
                temp.ContextMenuStrip = ctxtProject;
                treeView.Nodes.Add(temp);
            }
            tslPrj.Text = $"{result.Count}个项目";
            tslPackage.Visible = false;
        }

        private void EditPackage(PackageInfo packageInfo)
        {
            TabPage tabPage = null;
            if (tabControl1.TabPages.ContainsKey(packageInfo.Id) == false)
            {
                tabPage = new TabPage(packageInfo.Name);
                tabPage.Name = packageInfo.Id;
                IISPackageControl iISPackageControl = new IISPackageControl(packageInfo);
                iISPackageControl.Dock = DockStyle.Fill;
                tabPage.Controls.Add(iISPackageControl);
                tabControl1.Controls.Add(tabPage);
            }
            else
                tabPage = tabControl1.TabPages[packageInfo.Id];
            tabControl1.SelectedTab = tabPage;
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                EditPackage(listView1.SelectedItems[0].Tag as PackageInfo);
            }
        }

        private void 打开包ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PackageInfo packageInfo = treeView.SelectedNode.Tag as PackageInfo;
            EditPackage(packageInfo);
        }

        private void 编辑包ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PackageInfo packageInfo = treeView.SelectedNode.Tag as PackageInfo;
            FormPackage formPackage = new FormPackage(packageInfo);
            DialogResult dialogResult = formPackage.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                IniPackage(treeView.SelectedNode);
            }
        }

        private void 删除包ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PackageInfo packageInfo = treeView.SelectedNode.Tag as PackageInfo;
            var oprate = new OprateBase<PackageInfo>();
            oprate.Delete(packageInfo);
            IniPackage(treeView.SelectedNode);
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                PackageInfo packageInfo = listView1.SelectedItems[0].Tag as PackageInfo;
                EditPackage(packageInfo);
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                PackageInfo packageInfo = listView1.SelectedItems[0].Tag as PackageInfo;
                FormPackage formPackage = new FormPackage(packageInfo);
                DialogResult dialogResult = formPackage.ShowDialog();
                if (dialogResult == DialogResult.OK)
                {
                    IniPackage(FindNodeByName(packageInfo.Id, treeView.Nodes));
                }
            }
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                PackageInfo packageInfo = listView1.SelectedItems[0].Tag as PackageInfo;
                var oprate = new OprateBase<PackageInfo>();
                oprate.Delete(packageInfo);
                IniPackage(FindNodeByName(packageInfo.Id, treeView.Nodes));
            }
        }

        private TreeNode FindNodeByName(string name, TreeNodeCollection parentNode)
        {
            TreeNode result = null;
            foreach (TreeNode item in parentNode)
            {
                if (item.Name == name)
                {
                    result = item;
                    break;
                }
                else if (item.Nodes.Count > 0)
                {
                    result = FindNodeByName(name, item.Nodes);
                    if (result != null)
                        break;
                }
            }
            return result;
        }
    }
}
