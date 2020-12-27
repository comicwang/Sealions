namespace Deployment.Builder
{
    partial class FormMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新建项目ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新建包ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iISToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mysqlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开最近项目ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.运行ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.开始打包ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除包ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除项目ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.listView1 = new System.Windows.Forms.ListView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tslPrj = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslPackage = new System.Windows.Forms.ToolStripStatusLabel();
            this.ctxtProject = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.打开项目ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.编辑项目ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除项目ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.新建包ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxtPackage = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.打开包ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.编辑包ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除包ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.superPanel1 = new Deployment.Builder.Controller.SuperPanel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.ctxtProject.SuspendLayout();
            this.ctxtPackage.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.运行ToolStripMenuItem,
            this.设置ToolStripMenuItem,
            this.帮助ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1081, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新建项目ToolStripMenuItem,
            this.新建包ToolStripMenuItem,
            this.打开最近项目ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.文件ToolStripMenuItem.Text = "文件";
            // 
            // 新建项目ToolStripMenuItem
            // 
            this.新建项目ToolStripMenuItem.Name = "新建项目ToolStripMenuItem";
            this.新建项目ToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
            this.新建项目ToolStripMenuItem.Text = "新建项目";
            this.新建项目ToolStripMenuItem.Click += new System.EventHandler(this.新建项目ToolStripMenuItem_Click);
            // 
            // 新建包ToolStripMenuItem
            // 
            this.新建包ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iISToolStripMenuItem,
            this.backageToolStripMenuItem,
            this.mysqlToolStripMenuItem});
            this.新建包ToolStripMenuItem.Name = "新建包ToolStripMenuItem";
            this.新建包ToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
            this.新建包ToolStripMenuItem.Text = "新建包";
            // 
            // iISToolStripMenuItem
            // 
            this.iISToolStripMenuItem.Name = "iISToolStripMenuItem";
            this.iISToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.iISToolStripMenuItem.Text = "IIS";
            // 
            // backageToolStripMenuItem
            // 
            this.backageToolStripMenuItem.Name = "backageToolStripMenuItem";
            this.backageToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.backageToolStripMenuItem.Text = "Backage";
            // 
            // mysqlToolStripMenuItem
            // 
            this.mysqlToolStripMenuItem.Name = "mysqlToolStripMenuItem";
            this.mysqlToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.mysqlToolStripMenuItem.Text = "Mysql";
            // 
            // 打开最近项目ToolStripMenuItem
            // 
            this.打开最近项目ToolStripMenuItem.Name = "打开最近项目ToolStripMenuItem";
            this.打开最近项目ToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
            this.打开最近项目ToolStripMenuItem.Text = "打开最近项目";
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
            this.退出ToolStripMenuItem.Text = "退出";
            // 
            // 运行ToolStripMenuItem
            // 
            this.运行ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.开始打包ToolStripMenuItem,
            this.删除包ToolStripMenuItem,
            this.删除项目ToolStripMenuItem});
            this.运行ToolStripMenuItem.Name = "运行ToolStripMenuItem";
            this.运行ToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.运行ToolStripMenuItem.Text = "运行";
            // 
            // 开始打包ToolStripMenuItem
            // 
            this.开始打包ToolStripMenuItem.Name = "开始打包ToolStripMenuItem";
            this.开始打包ToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.开始打包ToolStripMenuItem.Text = "开始打包";
            // 
            // 删除包ToolStripMenuItem
            // 
            this.删除包ToolStripMenuItem.Name = "删除包ToolStripMenuItem";
            this.删除包ToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.删除包ToolStripMenuItem.Text = "删除包";
            // 
            // 删除项目ToolStripMenuItem
            // 
            this.删除项目ToolStripMenuItem.Name = "删除项目ToolStripMenuItem";
            this.删除项目ToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.删除项目ToolStripMenuItem.Text = "删除项目";
            // 
            // 设置ToolStripMenuItem
            // 
            this.设置ToolStripMenuItem.Name = "设置ToolStripMenuItem";
            this.设置ToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.设置ToolStripMenuItem.Text = "设置";
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.帮助ToolStripMenuItem.Text = "帮助";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(260, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(821, 634);
            this.panel1.TabIndex = 3;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.ItemSize = new System.Drawing.Size(60, 28);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(821, 634);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.listView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 32);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(813, 598);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "对象";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.ContextMenuStrip = this.contextMenuStrip1;
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.HideSelection = false;
            this.listView1.LargeImageList = this.imageList1;
            this.listView1.Location = new System.Drawing.Point(3, 3);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(807, 592);
            this.listView1.SmallImageList = this.imageList1;
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.SmallIcon;
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "package1.png");
            this.imageList1.Images.SetKeyName(1, "busi-config.png");
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(260, 28);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 634);
            this.splitter1.TabIndex = 5;
            this.splitter1.TabStop = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslPrj,
            this.toolStripStatusLabel2,
            this.tslPackage});
            this.statusStrip1.Location = new System.Drawing.Point(0, 662);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1081, 26);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tslPrj
            // 
            this.tslPrj.Name = "tslPrj";
            this.tslPrj.Size = new System.Drawing.Size(63, 20);
            this.tslPrj.Text = "0个项目";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(33, 20);
            this.toolStripStatusLabel2.Text = "|";
            // 
            // tslPackage
            // 
            this.tslPackage.Name = "tslPackage";
            this.tslPackage.Size = new System.Drawing.Size(48, 20);
            this.tslPackage.Text = "0个包";
            // 
            // ctxtProject
            // 
            this.ctxtProject.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ctxtProject.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.打开项目ToolStripMenuItem,
            this.编辑项目ToolStripMenuItem,
            this.删除项目ToolStripMenuItem1,
            this.新建包ToolStripMenuItem1});
            this.ctxtProject.Name = "ctxtProject";
            this.ctxtProject.Size = new System.Drawing.Size(139, 100);
            // 
            // 打开项目ToolStripMenuItem
            // 
            this.打开项目ToolStripMenuItem.Name = "打开项目ToolStripMenuItem";
            this.打开项目ToolStripMenuItem.Size = new System.Drawing.Size(138, 24);
            this.打开项目ToolStripMenuItem.Text = "打开项目";
            this.打开项目ToolStripMenuItem.Click += new System.EventHandler(this.打开项目ToolStripMenuItem_Click);
            // 
            // 编辑项目ToolStripMenuItem
            // 
            this.编辑项目ToolStripMenuItem.Name = "编辑项目ToolStripMenuItem";
            this.编辑项目ToolStripMenuItem.Size = new System.Drawing.Size(138, 24);
            this.编辑项目ToolStripMenuItem.Text = "编辑项目";
            this.编辑项目ToolStripMenuItem.Click += new System.EventHandler(this.编辑项目ToolStripMenuItem_Click);
            // 
            // 删除项目ToolStripMenuItem1
            // 
            this.删除项目ToolStripMenuItem1.Name = "删除项目ToolStripMenuItem1";
            this.删除项目ToolStripMenuItem1.Size = new System.Drawing.Size(138, 24);
            this.删除项目ToolStripMenuItem1.Text = "删除项目";
            this.删除项目ToolStripMenuItem1.Click += new System.EventHandler(this.删除项目ToolStripMenuItem1_Click);
            // 
            // 新建包ToolStripMenuItem1
            // 
            this.新建包ToolStripMenuItem1.Name = "新建包ToolStripMenuItem1";
            this.新建包ToolStripMenuItem1.Size = new System.Drawing.Size(138, 24);
            this.新建包ToolStripMenuItem1.Text = "新建包";
            this.新建包ToolStripMenuItem1.Click += new System.EventHandler(this.新建包ToolStripMenuItem1_Click);
            // 
            // ctxtPackage
            // 
            this.ctxtPackage.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ctxtPackage.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.打开包ToolStripMenuItem,
            this.编辑包ToolStripMenuItem,
            this.删除包ToolStripMenuItem1});
            this.ctxtPackage.Name = "ctxtPackage";
            this.ctxtPackage.Size = new System.Drawing.Size(124, 76);
            // 
            // 打开包ToolStripMenuItem
            // 
            this.打开包ToolStripMenuItem.Name = "打开包ToolStripMenuItem";
            this.打开包ToolStripMenuItem.Size = new System.Drawing.Size(123, 24);
            this.打开包ToolStripMenuItem.Text = "打开包";
            this.打开包ToolStripMenuItem.Click += new System.EventHandler(this.打开包ToolStripMenuItem_Click);
            // 
            // 编辑包ToolStripMenuItem
            // 
            this.编辑包ToolStripMenuItem.Name = "编辑包ToolStripMenuItem";
            this.编辑包ToolStripMenuItem.Size = new System.Drawing.Size(123, 24);
            this.编辑包ToolStripMenuItem.Text = "编辑包";
            this.编辑包ToolStripMenuItem.Click += new System.EventHandler(this.编辑包ToolStripMenuItem_Click);
            // 
            // 删除包ToolStripMenuItem1
            // 
            this.删除包ToolStripMenuItem1.Name = "删除包ToolStripMenuItem1";
            this.删除包ToolStripMenuItem1.Size = new System.Drawing.Size(123, 24);
            this.删除包ToolStripMenuItem1.Text = "删除包";
            this.删除包ToolStripMenuItem1.Click += new System.EventHandler(this.删除包ToolStripMenuItem1_Click);
            // 
            // superPanel1
            // 
            this.superPanel1.Closeable = false;
            this.superPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.superPanel1.Hidenable = false;
            this.superPanel1.Location = new System.Drawing.Point(0, 28);
            this.superPanel1.Name = "superPanel1";
            this.superPanel1.PanelName = "项目列表";
            this.superPanel1.Size = new System.Drawing.Size(260, 634);
            this.superPanel1.TabIndex = 1;
            this.superPanel1.Load += new System.EventHandler(this.superPanel1_Load);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3});
            this.contextMenuStrip1.Name = "ctxtPackage";
            this.contextMenuStrip1.Size = new System.Drawing.Size(211, 104);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(210, 24);
            this.toolStripMenuItem1.Text = "打开包";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(210, 24);
            this.toolStripMenuItem2.Text = "编辑包";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(210, 24);
            this.toolStripMenuItem3.Text = "删除包";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 688);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.superPanel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "Sealion软件发布打包管理系统";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ctxtProject.ResumeLayout(false);
            this.ctxtPackage.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新建项目ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新建包ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iISToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mysqlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开最近项目ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 运行ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 开始打包ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除包ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除项目ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private Controller.SuperPanel superPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tslPrj;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel tslPackage;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ContextMenuStrip ctxtProject;
        private System.Windows.Forms.ToolStripMenuItem 新建包ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 编辑项目ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开项目ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除项目ToolStripMenuItem1;
        private System.Windows.Forms.ContextMenuStrip ctxtPackage;
        private System.Windows.Forms.ToolStripMenuItem 打开包ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 编辑包ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除包ToolStripMenuItem1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
    }
}

