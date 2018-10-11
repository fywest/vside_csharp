namespace IDcardNo
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
            this.lblidcard = new System.Windows.Forms.Label();
            this.txtidcard = new System.Windows.Forms.TextBox();
            this.btnidcard = new System.Windows.Forms.Button();
            this.lblidcardInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblidcard
            // 
            this.lblidcard.AutoSize = true;
            this.lblidcard.Location = new System.Drawing.Point(42, 39);
            this.lblidcard.Name = "lblidcard";
            this.lblidcard.Size = new System.Drawing.Size(103, 13);
            this.lblidcard.TabIndex = 0;
            this.lblidcard.Text = "请输入身份证号码";
            // 
            // txtidcard
            // 
            this.txtidcard.Location = new System.Drawing.Point(45, 64);
            this.txtidcard.Name = "txtidcard";
            this.txtidcard.Size = new System.Drawing.Size(201, 20);
            this.txtidcard.TabIndex = 1;
            this.txtidcard.TextChanged += new System.EventHandler(this.txtidcard_TextChanged);
            // 
            // btnidcard
            // 
            this.btnidcard.Location = new System.Drawing.Point(45, 100);
            this.btnidcard.Name = "btnidcard";
            this.btnidcard.Size = new System.Drawing.Size(90, 23);
            this.btnidcard.TabIndex = 2;
            this.btnidcard.Text = "检查有效性";
            this.btnidcard.UseVisualStyleBackColor = true;
            this.btnidcard.Click += new System.EventHandler(this.btnidcard_Click);
            // 
            // lblidcardInfo
            // 
            this.lblidcardInfo.AutoSize = true;
            this.lblidcardInfo.Location = new System.Drawing.Point(45, 144);
            this.lblidcardInfo.Name = "lblidcardInfo";
            this.lblidcardInfo.Size = new System.Drawing.Size(55, 13);
            this.lblidcardInfo.TabIndex = 3;
            this.lblidcardInfo.Text = "检查结果";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 233);
            this.Controls.Add(this.lblidcardInfo);
            this.Controls.Add(this.btnidcard);
            this.Controls.Add(this.txtidcard);
            this.Controls.Add(this.lblidcard);
            this.Name = "Form1";
            this.Text = "ID Card No Verification";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblidcard;
        private System.Windows.Forms.TextBox txtidcard;
        private System.Windows.Forms.Button btnidcard;
        private System.Windows.Forms.Label lblidcardInfo;
    }
}

