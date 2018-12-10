namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.progress_button1 = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.progress_label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // progress_button1
            // 
            this.progress_button1.Location = new System.Drawing.Point(136, 364);
            this.progress_button1.Name = "progress_button1";
            this.progress_button1.Size = new System.Drawing.Size(128, 63);
            this.progress_button1.TabIndex = 0;
            this.progress_button1.Text = "progress_button1";
            this.progress_button1.UseVisualStyleBackColor = true;
            this.progress_button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(423, 399);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(340, 28);
            this.progressBar1.TabIndex = 1;
            // 
            // progress_label1
            // 
            this.progress_label1.AutoSize = true;
            this.progress_label1.Location = new System.Drawing.Point(419, 364);
            this.progress_label1.Name = "progress_label1";
            this.progress_label1.Size = new System.Drawing.Size(190, 24);
            this.progress_label1.TabIndex = 2;
            this.progress_label1.Text = "progress_label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.progress_label1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.progress_button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button progress_button1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label progress_label1;
    }
}

