namespace WebTranslation
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
            this.rtxFrom = new System.Windows.Forms.RichTextBox();
            this.rtxTo = new System.Windows.Forms.RichTextBox();
            this.btnTranslate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblInput = new System.Windows.Forms.Label();
            this.rtxTo2 = new System.Windows.Forms.RichTextBox();
            this.lblOutput = new System.Windows.Forms.Label();
            this.lblOutput2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rtxFrom
            // 
            this.rtxFrom.Location = new System.Drawing.Point(80, 84);
            this.rtxFrom.Name = "rtxFrom";
            this.rtxFrom.Size = new System.Drawing.Size(374, 103);
            this.rtxFrom.TabIndex = 0;
            this.rtxFrom.Text = "";
            // 
            // rtxTo
            // 
            this.rtxTo.Location = new System.Drawing.Point(80, 270);
            this.rtxTo.Name = "rtxTo";
            this.rtxTo.Size = new System.Drawing.Size(374, 103);
            this.rtxTo.TabIndex = 1;
            this.rtxTo.Text = "";
            // 
            // btnTranslate
            // 
            this.btnTranslate.Location = new System.Drawing.Point(227, 45);
            this.btnTranslate.Name = "btnTranslate";
            this.btnTranslate.Size = new System.Drawing.Size(106, 23);
            this.btnTranslate.TabIndex = 2;
            this.btnTranslate.Text = "translate";// "翻译";
            this.btnTranslate.UseVisualStyleBackColor = true;
            this.btnTranslate.Click += new System.EventHandler(this.btnTranslate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(358, 44);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(96, 23);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "empty";// "清空";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.Location = new System.Drawing.Point(80, 53);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(55, 13);
            this.lblInput.TabIndex = 4;
            this.lblInput.Text = "input chinese";// "输入中文";
            // 
            // rtxTo2
            // 
            this.rtxTo2.Location = new System.Drawing.Point(80, 461);
            this.rtxTo2.Name = "rtxTo2";
            this.rtxTo2.Size = new System.Drawing.Size(374, 103);
            this.rtxTo2.TabIndex = 5;
            this.rtxTo2.Text = "";
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(80, 245);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(55, 13);
            this.lblOutput.TabIndex = 6;
            this.lblOutput.Text = "output english";// "输出英文";
            // 
            // lblOutput2
            // 
            this.lblOutput2.AutoSize = true;
            this.lblOutput2.Location = new System.Drawing.Point(83, 436);
            this.lblOutput2.Name = "lblOutput2";
            this.lblOutput2.Size = new System.Drawing.Size(55, 13);
            this.lblOutput2.TabIndex = 7;
            this.lblOutput2.Text = "output traditional chinese";// "输出繁体";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 628);
            this.Controls.Add(this.lblOutput2);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.rtxTo2);
            this.Controls.Add(this.lblInput);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnTranslate);
            this.Controls.Add(this.rtxTo);
            this.Controls.Add(this.rtxFrom);
            this.Name = "Form1";
            this.Text = "百度翻译";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtxFrom;
        private System.Windows.Forms.RichTextBox rtxTo;
        private System.Windows.Forms.Button btnTranslate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.RichTextBox rtxTo2;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Label lblOutput2;
    }
}

