namespace electronicSeal
{
    partial class Form1
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
            this.lblSeal = new System.Windows.Forms.Label();
            this.txtSeal = new System.Windows.Forms.TextBox();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnFont = new System.Windows.Forms.Button();
            this.lblFont = new System.Windows.Forms.Label();
            this.trbSeal = new System.Windows.Forms.TrackBar();
            this.lblSize = new System.Windows.Forms.Label();
            this.lblSizePercent = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trbSeal)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSeal
            // 
            this.lblSeal.AutoSize = true;
            this.lblSeal.Location = new System.Drawing.Point(12, 13);
            this.lblSeal.Name = "lblSeal";
            this.lblSeal.Size = new System.Drawing.Size(79, 13);
            this.lblSeal.TabIndex = 0;
            this.lblSeal.Text = "设置印章内容";
            // 
            // txtSeal
            // 
            this.txtSeal.Location = new System.Drawing.Point(98, 10);
            this.txtSeal.Name = "txtSeal";
            this.txtSeal.Size = new System.Drawing.Size(135, 20);
            this.txtSeal.TabIndex = 1;
            this.txtSeal.Text = "无用阶级第八周作业";
            this.txtSeal.TextChanged += new System.EventHandler(this.txtSeal_TextChanged);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(239, 10);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(33, 48);
            this.btnConfirm.TabIndex = 2;
            this.btnConfirm.Text = "确认";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnFont
            // 
            this.btnFont.Location = new System.Drawing.Point(98, 35);
            this.btnFont.Name = "btnFont";
            this.btnFont.Size = new System.Drawing.Size(135, 23);
            this.btnFont.TabIndex = 3;
            this.btnFont.Text = "打开字体设置对话框";
            this.btnFont.UseVisualStyleBackColor = true;
            this.btnFont.Click += new System.EventHandler(this.btnFont_Click);
            // 
            // lblFont
            // 
            this.lblFont.AutoSize = true;
            this.lblFont.Location = new System.Drawing.Point(13, 40);
            this.lblFont.Name = "lblFont";
            this.lblFont.Size = new System.Drawing.Size(79, 13);
            this.lblFont.TabIndex = 4;
            this.lblFont.Text = "设置印章字体";
            // 
            // trbSeal
            // 
            this.trbSeal.LargeChange = 2;
            this.trbSeal.Location = new System.Drawing.Point(98, 64);
            this.trbSeal.Maximum = 15;
            this.trbSeal.Minimum = 5;
            this.trbSeal.Name = "trbSeal";
            this.trbSeal.Size = new System.Drawing.Size(135, 45);
            this.trbSeal.TabIndex = 1;
            this.trbSeal.Value = 10;
            this.trbSeal.ValueChanged += new System.EventHandler(this.trbSeal_ValueChanged);
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(13, 64);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(79, 13);
            this.lblSize.TabIndex = 5;
            this.lblSize.Text = "设置印章比例";
            // 
            // lblSizePercent
            // 
            this.lblSizePercent.AutoSize = true;
            this.lblSizePercent.Location = new System.Drawing.Point(239, 64);
            this.lblSizePercent.Name = "lblSizePercent";
            this.lblSizePercent.Size = new System.Drawing.Size(33, 13);
            this.lblSizePercent.TabIndex = 6;
            this.lblSizePercent.Text = "100%";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 411);
            this.Controls.Add(this.lblSizePercent);
            this.Controls.Add(this.lblSize);
            this.Controls.Add(this.trbSeal);
            this.Controls.Add(this.lblFont);
            this.Controls.Add(this.btnFont);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.txtSeal);
            this.Controls.Add(this.lblSeal);
            this.Name = "Form1";
            this.Text = "Electronic Seal";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.trbSeal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSeal;
        private System.Windows.Forms.TextBox txtSeal;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnFont;
        private System.Windows.Forms.Label lblFont;
        private System.Windows.Forms.TrackBar trbSeal;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lblSizePercent;
    }
}

