namespace reciteWord1
{
    partial class Form3
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
            this.components = new System.ComponentModel.Container();
            this.lblEn = new System.Windows.Forms.Label();
            this.lblCh = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdoLoop = new System.Windows.Forms.RadioButton();
            this.rdoRandom = new System.Windows.Forms.RadioButton();
            this.trbTimer = new System.Windows.Forms.TrackBar();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbTimer)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEn
            // 
            this.lblEn.AutoSize = true;
            this.lblEn.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEn.Location = new System.Drawing.Point(25, 29);
            this.lblEn.Name = "lblEn";
            this.lblEn.Size = new System.Drawing.Size(137, 42);
            this.lblEn.TabIndex = 1;
            this.lblEn.Text = "english";
            // 
            // lblCh
            // 
            this.lblCh.AutoSize = true;
            this.lblCh.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCh.Location = new System.Drawing.Point(25, 106);
            this.lblCh.Name = "lblCh";
            this.lblCh.Size = new System.Drawing.Size(108, 31);
            this.lblCh.TabIndex = 2;
            this.lblCh.Text = "chinese";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(32, 214);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(145, 213);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(75, 23);
            this.btnPrevious.TabIndex = 4;
            this.btnPrevious.Text = "previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(257, 213);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 5;
            this.btnNext.Text = "next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdoLoop);
            this.panel1.Controls.Add(this.rdoRandom);
            this.panel1.Location = new System.Drawing.Point(32, 255);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(75, 40);
            this.panel1.TabIndex = 6;
            // 
            // rdoLoop
            // 
            this.rdoLoop.AutoSize = true;
            this.rdoLoop.Location = new System.Drawing.Point(3, 20);
            this.rdoLoop.Name = "rdoLoop";
            this.rdoLoop.Size = new System.Drawing.Size(45, 17);
            this.rdoLoop.TabIndex = 1;
            this.rdoLoop.Text = "loop";
            this.rdoLoop.UseVisualStyleBackColor = true;
            // 
            // rdoRandom
            // 
            this.rdoRandom.AutoSize = true;
            this.rdoRandom.Checked = true;
            this.rdoRandom.Location = new System.Drawing.Point(4, 4);
            this.rdoRandom.Name = "rdoRandom";
            this.rdoRandom.Size = new System.Drawing.Size(60, 17);
            this.rdoRandom.TabIndex = 0;
            this.rdoRandom.TabStop = true;
            this.rdoRandom.Text = "random";
            this.rdoRandom.UseVisualStyleBackColor = true;
            // 
            // trbTimer
            // 
            this.trbTimer.Location = new System.Drawing.Point(145, 275);
            this.trbTimer.Maximum = 15;
            this.trbTimer.Minimum = 1;
            this.trbTimer.Name = "trbTimer";
            this.trbTimer.Size = new System.Drawing.Size(187, 45);
            this.trbTimer.TabIndex = 7;
            this.trbTimer.Value = 1;
            this.trbTimer.ValueChanged += new System.EventHandler(this.trbTimer_ValueChanged);
            // 
            // lblSpeed
            // 
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.Location = new System.Drawing.Point(192, 255);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(59, 13);
            this.lblSpeed.TabIndex = 8;
            this.lblSpeed.Text = "Speed(mS)";
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 328);
            this.Controls.Add(this.lblSpeed);
            this.Controls.Add(this.trbTimer);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblCh);
            this.Controls.Add(this.lblEn);
            this.Name = "Form3";
            this.Text = "Form3";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form3_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbTimer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEn;
        private System.Windows.Forms.Label lblCh;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rdoLoop;
        private System.Windows.Forms.RadioButton rdoRandom;
        private System.Windows.Forms.TrackBar trbTimer;
        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.Timer timer2;
    }
}