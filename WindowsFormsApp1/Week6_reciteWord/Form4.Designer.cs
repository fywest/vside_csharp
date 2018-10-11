namespace reciteWord1
{
    partial class Form4
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
            this.lblQuestion = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdoChoice4 = new System.Windows.Forms.RadioButton();
            this.rdoChoice3 = new System.Windows.Forms.RadioButton();
            this.rdoChoice2 = new System.Windows.Forms.RadioButton();
            this.rdoChoice1 = new System.Windows.Forms.RadioButton();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.Location = new System.Drawing.Point(12, 22);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(105, 29);
            this.lblQuestion.TabIndex = 0;
            this.lblQuestion.Text = "question";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdoChoice4);
            this.panel1.Controls.Add(this.rdoChoice3);
            this.panel1.Controls.Add(this.rdoChoice2);
            this.panel1.Controls.Add(this.rdoChoice1);
            this.panel1.Location = new System.Drawing.Point(12, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(286, 181);
            this.panel1.TabIndex = 1;
            // 
            // rdoChoice4
            // 
            this.rdoChoice4.AutoSize = true;
            this.rdoChoice4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoChoice4.Location = new System.Drawing.Point(11, 131);
            this.rdoChoice4.Name = "rdoChoice4";
            this.rdoChoice4.Size = new System.Drawing.Size(85, 24);
            this.rdoChoice4.TabIndex = 3;
            this.rdoChoice4.TabStop = true;
            this.rdoChoice4.Text = "Choice4";
            this.rdoChoice4.UseVisualStyleBackColor = true;
            this.rdoChoice4.CheckedChanged += new System.EventHandler(this.rdoChoice4_CheckedChanged);
            // 
            // rdoChoice3
            // 
            this.rdoChoice3.AutoSize = true;
            this.rdoChoice3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoChoice3.Location = new System.Drawing.Point(11, 94);
            this.rdoChoice3.Name = "rdoChoice3";
            this.rdoChoice3.Size = new System.Drawing.Size(85, 24);
            this.rdoChoice3.TabIndex = 2;
            this.rdoChoice3.TabStop = true;
            this.rdoChoice3.Text = "Choice3";
            this.rdoChoice3.UseVisualStyleBackColor = true;
            // 
            // rdoChoice2
            // 
            this.rdoChoice2.AutoSize = true;
            this.rdoChoice2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoChoice2.Location = new System.Drawing.Point(11, 57);
            this.rdoChoice2.Name = "rdoChoice2";
            this.rdoChoice2.Size = new System.Drawing.Size(85, 24);
            this.rdoChoice2.TabIndex = 1;
            this.rdoChoice2.TabStop = true;
            this.rdoChoice2.Text = "Choice2";
            this.rdoChoice2.UseVisualStyleBackColor = true;
            // 
            // rdoChoice1
            // 
            this.rdoChoice1.AutoSize = true;
            this.rdoChoice1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoChoice1.Location = new System.Drawing.Point(11, 20);
            this.rdoChoice1.Name = "rdoChoice1";
            this.rdoChoice1.Size = new System.Drawing.Size(85, 24);
            this.rdoChoice1.TabIndex = 0;
            this.rdoChoice1.TabStop = true;
            this.rdoChoice1.Text = "Choice1";
            this.rdoChoice1.UseVisualStyleBackColor = true;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(174, 9);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(124, 42);
            this.lblResult.TabIndex = 2;
            this.lblResult.Text = "Result";
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(12, 260);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(74, 29);
            this.btnNext.TabIndex = 3;
            this.btnNext.Text = "next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.Location = new System.Drawing.Point(117, 260);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(74, 29);
            this.btnConfirm.TabIndex = 4;
            this.btnConfirm.Text = "confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(224, 260);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(74, 29);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 301);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblQuestion);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rdoChoice4;
        private System.Windows.Forms.RadioButton rdoChoice3;
        private System.Windows.Forms.RadioButton rdoChoice2;
        private System.Windows.Forms.RadioButton rdoChoice1;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnExit;
    }
}