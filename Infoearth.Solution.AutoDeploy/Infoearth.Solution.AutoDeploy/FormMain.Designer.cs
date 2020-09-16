namespace Infoearth.Solution.AutoDeploy
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
            this.label4 = new System.Windows.Forms.Label();
            this.txtRoot = new System.Windows.Forms.TextBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.deployDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.webNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.portDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dirctoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.domainDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deployDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnCheck = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.tabControls = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pnlGlobal = new System.Windows.Forms.Panel();
            this.lklblClearGlobal = new System.Windows.Forms.LinkLabel();
            this.lklblAddGlobal = new System.Windows.Forms.LinkLabel();
            this.lklblLoalGlobal = new System.Windows.Forms.LinkLabel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.enviromentPnl = new System.Windows.Forms.FlowLayoutPanel();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnAddFilter = new System.Windows.Forms.Button();
            this.btnClearFilter = new System.Windows.Forms.Button();
            this.cklsbFilter = new System.Windows.Forms.CheckedListBox();
            this.statusStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deployDataBindingSource)).BeginInit();
            this.tabControls.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 15);
            this.label4.TabIndex = 31;
            this.label4.Text = "部署资源目录：";
            // 
            // txtRoot
            // 
            this.txtRoot.Location = new System.Drawing.Point(151, 15);
            this.txtRoot.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRoot.Name = "txtRoot";
            this.txtRoot.Size = new System.Drawing.Size(719, 25);
            this.txtRoot.TabIndex = 32;
            this.txtRoot.TextChanged += new System.EventHandler(this.txtRoot_TextChanged);
            this.txtRoot.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.txtRoot_MouseDoubleClick);
            // 
            // btnLoad
            // 
            this.btnLoad.Enabled = false;
            this.btnLoad.Location = new System.Drawing.Point(889, 14);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 28);
            this.btnLoad.TabIndex = 33;
            this.btnLoad.Text = "加载";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 624);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 13, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1005, 26);
            this.statusStrip1.TabIndex = 34;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(167, 20);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(29, 62);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(329, 431);
            this.tabControl1.TabIndex = 35;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtFilter);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(321, 402);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "IIS发布:";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(5, 372);
            this.txtFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(311, 25);
            this.txtFilter.TabIndex = 1;
            this.txtFilter.Text = "输入名称按【Enter】过滤";
            this.txtFilter.Enter += new System.EventHandler(this.txtFilter_Enter);
            this.txtFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilter_KeyPress);
            this.txtFilter.Leave += new System.EventHandler(this.txtFilter_Leave);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.deployDataGridViewCheckBoxColumn,
            this.webNameDataGridViewTextBoxColumn,
            this.portDataGridViewTextBoxColumn,
            this.dirctoryDataGridViewTextBoxColumn,
            this.domainDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.deployDataBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(3, 2);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(315, 362);
            this.dataGridView1.TabIndex = 0;
            // 
            // deployDataGridViewCheckBoxColumn
            // 
            this.deployDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.deployDataGridViewCheckBoxColumn.DataPropertyName = "Deploy";
            this.deployDataGridViewCheckBoxColumn.FillWeight = 40F;
            this.deployDataGridViewCheckBoxColumn.HeaderText = "";
            this.deployDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.deployDataGridViewCheckBoxColumn.Name = "deployDataGridViewCheckBoxColumn";
            // 
            // webNameDataGridViewTextBoxColumn
            // 
            this.webNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.webNameDataGridViewTextBoxColumn.DataPropertyName = "WebName";
            this.webNameDataGridViewTextBoxColumn.HeaderText = "名称";
            this.webNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.webNameDataGridViewTextBoxColumn.Name = "webNameDataGridViewTextBoxColumn";
            // 
            // portDataGridViewTextBoxColumn
            // 
            this.portDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.portDataGridViewTextBoxColumn.DataPropertyName = "Port";
            this.portDataGridViewTextBoxColumn.FillWeight = 60F;
            this.portDataGridViewTextBoxColumn.HeaderText = "端口";
            this.portDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.portDataGridViewTextBoxColumn.Name = "portDataGridViewTextBoxColumn";
            // 
            // dirctoryDataGridViewTextBoxColumn
            // 
            this.dirctoryDataGridViewTextBoxColumn.DataPropertyName = "Dirctory";
            this.dirctoryDataGridViewTextBoxColumn.HeaderText = "Dirctory";
            this.dirctoryDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dirctoryDataGridViewTextBoxColumn.Name = "dirctoryDataGridViewTextBoxColumn";
            this.dirctoryDataGridViewTextBoxColumn.Visible = false;
            // 
            // domainDataGridViewTextBoxColumn
            // 
            this.domainDataGridViewTextBoxColumn.DataPropertyName = "Domain";
            this.domainDataGridViewTextBoxColumn.HeaderText = "Domain";
            this.domainDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.domainDataGridViewTextBoxColumn.Name = "domainDataGridViewTextBoxColumn";
            this.domainDataGridViewTextBoxColumn.Visible = false;
            // 
            // deployDataBindingSource
            // 
            this.deployDataBindingSource.DataSource = typeof(Infoearth.Solution.AutoDeploy.Model.DeployData);
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(31, 499);
            this.btnCheck.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(99, 32);
            this.btnCheck.TabIndex = 36;
            this.btnCheck.Text = "反（全）选";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(151, 499);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(91, 32);
            this.button4.TabIndex = 36;
            this.button4.Text = "清空";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(267, 499);
            this.btnImport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(91, 32);
            this.btnImport.TabIndex = 36;
            this.btnImport.Text = "导入项";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // tabControls
            // 
            this.tabControls.Controls.Add(this.tabPage4);
            this.tabControls.Controls.Add(this.tabPage2);
            this.tabControls.Controls.Add(this.tabPage6);
            this.tabControls.Controls.Add(this.tabPage3);
            this.tabControls.Controls.Add(this.tabPage5);
            this.tabControls.Controls.Add(this.tabPage7);
            this.tabControls.Location = new System.Drawing.Point(397, 62);
            this.tabControls.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControls.Name = "tabControls";
            this.tabControls.SelectedIndex = 0;
            this.tabControls.Size = new System.Drawing.Size(567, 469);
            this.tabControls.TabIndex = 37;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.groupBox1);
            this.tabPage4.Controls.Add(this.lklblClearGlobal);
            this.tabPage4.Controls.Add(this.lklblAddGlobal);
            this.tabPage4.Controls.Add(this.lklblLoalGlobal);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage4.Size = new System.Drawing.Size(559, 440);
            this.tabPage4.TabIndex = 2;
            this.tabPage4.Text = "全局";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pnlGlobal);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(3, 2);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(553, 399);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "配置项";
            // 
            // pnlGlobal
            // 
            this.pnlGlobal.AutoScroll = true;
            this.pnlGlobal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGlobal.Location = new System.Drawing.Point(3, 20);
            this.pnlGlobal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlGlobal.Name = "pnlGlobal";
            this.pnlGlobal.Size = new System.Drawing.Size(547, 377);
            this.pnlGlobal.TabIndex = 1;
            // 
            // lklblClearGlobal
            // 
            this.lklblClearGlobal.AutoSize = true;
            this.lklblClearGlobal.Location = new System.Drawing.Point(203, 412);
            this.lklblClearGlobal.Name = "lklblClearGlobal";
            this.lklblClearGlobal.Size = new System.Drawing.Size(67, 15);
            this.lklblClearGlobal.TabIndex = 1;
            this.lklblClearGlobal.TabStop = true;
            this.lklblClearGlobal.Text = "清空全局";
            this.lklblClearGlobal.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklblClearGlobal_LinkClicked);
            // 
            // lklblAddGlobal
            // 
            this.lklblAddGlobal.AutoSize = true;
            this.lklblAddGlobal.Location = new System.Drawing.Point(113, 412);
            this.lklblAddGlobal.Name = "lklblAddGlobal";
            this.lklblAddGlobal.Size = new System.Drawing.Size(67, 15);
            this.lklblAddGlobal.TabIndex = 1;
            this.lklblAddGlobal.TabStop = true;
            this.lklblAddGlobal.Text = "新增全局";
            this.lklblAddGlobal.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklblAddGlobal_LinkClicked);
            // 
            // lklblLoalGlobal
            // 
            this.lklblLoalGlobal.AutoSize = true;
            this.lklblLoalGlobal.Location = new System.Drawing.Point(15, 412);
            this.lklblLoalGlobal.Name = "lklblLoalGlobal";
            this.lklblLoalGlobal.Size = new System.Drawing.Size(67, 15);
            this.lklblLoalGlobal.TabIndex = 1;
            this.lklblLoalGlobal.TabStop = true;
            this.lklblLoalGlobal.Text = "加载全局";
            this.lklblLoalGlobal.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklblLoalGlobal_LinkClicked);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.pnlMain);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(559, 440);
            this.tabPage2.TabIndex = 0;
            this.tabPage2.Text = "IP配置";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // pnlMain
            // 
            this.pnlMain.AutoScroll = true;
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(3, 2);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(553, 436);
            this.pnlMain.TabIndex = 1;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.enviromentPnl);
            this.tabPage6.Location = new System.Drawing.Point(4, 25);
            this.tabPage6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage6.Size = new System.Drawing.Size(559, 440);
            this.tabPage6.TabIndex = 4;
            this.tabPage6.Text = "环境包";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // enviromentPnl
            // 
            this.enviromentPnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.enviromentPnl.Location = new System.Drawing.Point(3, 2);
            this.enviromentPnl.Name = "enviromentPnl";
            this.enviromentPnl.Size = new System.Drawing.Size(553, 436);
            this.enviromentPnl.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.propertyGrid1);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage3.Size = new System.Drawing.Size(559, 440);
            this.tabPage3.TabIndex = 1;
            this.tabPage3.Text = "关于本机";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertyGrid1.Location = new System.Drawing.Point(3, 2);
            this.propertyGrid1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.Size = new System.Drawing.Size(553, 436);
            this.propertyGrid1.TabIndex = 0;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.label3);
            this.tabPage5.Controls.Add(this.label1);
            this.tabPage5.Controls.Add(this.label2);
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage5.Size = new System.Drawing.Size(559, 440);
            this.tabPage5.TabIndex = 3;
            this.tabPage5.Text = "tabPage5";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 15);
            this.label3.TabIndex = 47;
            this.label3.Text = "3.环境自动安装";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 15);
            this.label1.TabIndex = 46;
            this.label1.Text = "1.程序自动发布";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 15);
            this.label2.TabIndex = 48;
            this.label2.Text = "2.数据库自动部署";
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.treeView1);
            this.tabPage7.Location = new System.Drawing.Point(4, 25);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(559, 440);
            this.tabPage7.TabIndex = 5;
            this.tabPage7.Text = "tabPage7";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.ImageIndex = 0;
            this.treeView1.ImageList = this.imageList1;
            this.treeView1.Location = new System.Drawing.Point(3, 3);
            this.treeView1.Name = "treeView1";
            this.treeView1.SelectedImageIndex = 0;
            this.treeView1.Size = new System.Drawing.Size(553, 434);
            this.treeView1.TabIndex = 0;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "dir.png");
            this.imageList1.Images.SetKeyName(1, "file.png");
            // 
            // btnAddFilter
            // 
            this.btnAddFilter.Location = new System.Drawing.Point(829, 545);
            this.btnAddFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddFilter.Name = "btnAddFilter";
            this.btnAddFilter.Size = new System.Drawing.Size(131, 28);
            this.btnAddFilter.TabIndex = 39;
            this.btnAddFilter.Text = "增加配置筛选";
            this.btnAddFilter.UseVisualStyleBackColor = true;
            this.btnAddFilter.Click += new System.EventHandler(this.btnAddFilter_Click);
            // 
            // btnClearFilter
            // 
            this.btnClearFilter.Location = new System.Drawing.Point(829, 581);
            this.btnClearFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClearFilter.Name = "btnClearFilter";
            this.btnClearFilter.Size = new System.Drawing.Size(131, 28);
            this.btnClearFilter.TabIndex = 39;
            this.btnClearFilter.Text = "清空筛选项";
            this.btnClearFilter.UseVisualStyleBackColor = true;
            this.btnClearFilter.Click += new System.EventHandler(this.btnClearFilter_Click);
            // 
            // cklsbFilter
            // 
            this.cklsbFilter.CheckOnClick = true;
            this.cklsbFilter.FormattingEnabled = true;
            this.cklsbFilter.Items.AddRange(new object[] {
            "geomap.xml",
            "web.config"});
            this.cklsbFilter.Location = new System.Drawing.Point(29, 545);
            this.cklsbFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cklsbFilter.MultiColumn = true;
            this.cklsbFilter.Name = "cklsbFilter";
            this.cklsbFilter.Size = new System.Drawing.Size(779, 64);
            this.cklsbFilter.TabIndex = 40;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 650);
            this.Controls.Add(this.cklsbFilter);
            this.Controls.Add(this.btnClearFilter);
            this.Controls.Add(this.btnAddFilter);
            this.Controls.Add(this.tabControls);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.txtRoot);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "自动化发布部署工具（6.0版本）";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deployDataBindingSource)).EndInit();
            this.tabControls.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.tabPage7.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRoot;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource deployDataBindingSource;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.DataGridViewCheckBoxColumn deployDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn webNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn portDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dirctoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn domainDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.TabControl tabControls;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.PropertyGrid propertyGrid1;
        private System.Windows.Forms.Button btnAddFilter;
        private System.Windows.Forms.Button btnClearFilter;
        private System.Windows.Forms.CheckedListBox cklsbFilter;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel lklblClearGlobal;
        private System.Windows.Forms.LinkLabel lklblAddGlobal;
        private System.Windows.Forms.LinkLabel lklblLoalGlobal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel pnlGlobal;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.FlowLayoutPanel enviromentPnl;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ImageList imageList1;
    }
}

