namespace package.builder
{
    partial class IISPackageControl
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.导入包ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.开始打包ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.清空包ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.导入包ToolStripMenuItem,
            this.开始打包ToolStripMenuItem,
            this.清空包ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(801, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 导入包ToolStripMenuItem
            // 
            this.导入包ToolStripMenuItem.Image = global::package.builder.Properties.Resources.import;
            this.导入包ToolStripMenuItem.Name = "导入包ToolStripMenuItem";
            this.导入包ToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.导入包ToolStripMenuItem.Text = "导入包";
            // 
            // 开始打包ToolStripMenuItem
            // 
            this.开始打包ToolStripMenuItem.Image = global::package.builder.Properties.Resources.zippackage;
            this.开始打包ToolStripMenuItem.Name = "开始打包ToolStripMenuItem";
            this.开始打包ToolStripMenuItem.Size = new System.Drawing.Size(103, 24);
            this.开始打包ToolStripMenuItem.Text = "开始打包";
            // 
            // 清空包ToolStripMenuItem
            // 
            this.清空包ToolStripMenuItem.Image = global::package.builder.Properties.Resources.package1;
            this.清空包ToolStripMenuItem.Name = "清空包ToolStripMenuItem";
            this.清空包ToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.清空包ToolStripMenuItem.Text = "清空包";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 28);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.treeView1);
            this.splitContainer1.Size = new System.Drawing.Size(801, 612);
            this.splitContainer1.SplitterDistance = 267;
            this.splitContainer1.TabIndex = 1;
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(267, 612);
            this.treeView1.TabIndex = 0;
            // 
            // IISPackageControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "IISPackageControl";
            this.Size = new System.Drawing.Size(801, 640);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 导入包ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 开始打包ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 清空包ToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView treeView1;
    }
}
