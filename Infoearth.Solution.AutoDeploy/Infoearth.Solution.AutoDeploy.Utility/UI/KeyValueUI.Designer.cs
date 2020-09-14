namespace Infoearth.Solution.AutoDeploy.Utility.UI
{
    partial class KeyValueUI
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
            this.txtValue = new System.Windows.Forms.TextBox();
            this.lblKey = new System.Windows.Forms.Label();
            this.ckUsed = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txtValue
            // 
            this.txtValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtValue.Location = new System.Drawing.Point(7, 28);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(363, 25);
            this.txtValue.TabIndex = 0;
            this.txtValue.TextChanged += new System.EventHandler(this.txtValue_TextChanged);
            // 
            // lblKey
            // 
            this.lblKey.AutoSize = true;
            this.lblKey.Location = new System.Drawing.Point(11, 5);
            this.lblKey.Name = "lblKey";
            this.lblKey.Size = new System.Drawing.Size(55, 15);
            this.lblKey.TabIndex = 1;
            this.lblKey.Text = "label1";
            // 
            // ckUsed
            // 
            this.ckUsed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ckUsed.AutoSize = true;
            this.ckUsed.Location = new System.Drawing.Point(351, 4);
            this.ckUsed.Name = "ckUsed";
            this.ckUsed.Size = new System.Drawing.Size(18, 17);
            this.ckUsed.TabIndex = 2;
            this.ckUsed.UseVisualStyleBackColor = true;
            this.ckUsed.Visible = false;
            this.ckUsed.CheckedChanged += new System.EventHandler(this.ckUsed_CheckedChanged);
            // 
            // KeyValueUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ckUsed);
            this.Controls.Add(this.lblKey);
            this.Controls.Add(this.txtValue);
            this.Name = "KeyValueUI";
            this.Size = new System.Drawing.Size(379, 60);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.Label lblKey;
        private System.Windows.Forms.CheckBox ckUsed;
    }
}
