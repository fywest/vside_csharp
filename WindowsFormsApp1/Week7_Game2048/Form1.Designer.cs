namespace Game2048
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlBoard = new System.Windows.Forms.Panel();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblScoreLabel = new System.Windows.Forms.Label();
            this.lblHighScoreLabel = new System.Windows.Forms.Label();
            this.lblHighScore = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdonumber = new System.Windows.Forms.RadioButton();
            this.rdoDynasty = new System.Windows.Forms.RadioButton();
            this.rdoGovenment = new System.Windows.Forms.RadioButton();
            this.rdoArmy = new System.Windows.Forms.RadioButton();
            this.lblCongratulation = new System.Windows.Forms.Label();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBoard
            // 
            this.pnlBoard.Location = new System.Drawing.Point(12, 101);
            this.pnlBoard.Name = "pnlBoard";
            this.pnlBoard.Size = new System.Drawing.Size(276, 296);
            this.pnlBoard.TabIndex = 0;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(20, 40);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(32, 33);
            this.lblScore.TabIndex = 1;
            this.lblScore.Text = "0";
            // 
            // lblScoreLabel
            // 
            this.lblScoreLabel.AutoSize = true;
            this.lblScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScoreLabel.Location = new System.Drawing.Point(19, 9);
            this.lblScoreLabel.Name = "lblScoreLabel";
            this.lblScoreLabel.Size = new System.Drawing.Size(73, 25);
            this.lblScoreLabel.TabIndex = 2;
            this.lblScoreLabel.Text = "Score";
            // 
            // lblHighScoreLabel
            // 
            this.lblHighScoreLabel.AutoSize = true;
            this.lblHighScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHighScoreLabel.Location = new System.Drawing.Point(149, 9);
            this.lblHighScoreLabel.Name = "lblHighScoreLabel";
            this.lblHighScoreLabel.Size = new System.Drawing.Size(121, 25);
            this.lblHighScoreLabel.TabIndex = 4;
            this.lblHighScoreLabel.Text = "HighScore";
            // 
            // lblHighScore
            // 
            this.lblHighScore.AutoSize = true;
            this.lblHighScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHighScore.Location = new System.Drawing.Point(150, 40);
            this.lblHighScore.Name = "lblHighScore";
            this.lblHighScore.Size = new System.Drawing.Size(32, 33);
            this.lblHighScore.TabIndex = 3;
            this.lblHighScore.Text = "0";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdoArmy);
            this.panel1.Controls.Add(this.rdoGovenment);
            this.panel1.Controls.Add(this.rdoDynasty);
            this.panel1.Controls.Add(this.rdonumber);
            this.panel1.Location = new System.Drawing.Point(12, 72);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(276, 23);
            this.panel1.TabIndex = 5;
            // 
            // rdonumber
            // 
            this.rdonumber.AutoSize = true;
            this.rdonumber.Checked = true;
            this.rdonumber.Location = new System.Drawing.Point(0, 3);
            this.rdonumber.Name = "rdonumber";
            this.rdonumber.Size = new System.Drawing.Size(49, 17);
            this.rdonumber.TabIndex = 0;
            this.rdonumber.TabStop = true;
            this.rdonumber.Text = "数字";
            this.rdonumber.UseVisualStyleBackColor = true;
            this.rdonumber.CheckedChanged += new System.EventHandler(this.rdonumber_CheckedChanged);
            // 
            // rdoDynasty
            // 
            this.rdoDynasty.AutoSize = true;
            this.rdoDynasty.Location = new System.Drawing.Point(69, 3);
            this.rdoDynasty.Name = "rdoDynasty";
            this.rdoDynasty.Size = new System.Drawing.Size(49, 17);
            this.rdoDynasty.TabIndex = 1;
            this.rdoDynasty.Text = "朝代";
            this.rdoDynasty.UseVisualStyleBackColor = true;
            this.rdoDynasty.CheckedChanged += new System.EventHandler(this.rdoDynasty_CheckedChanged);
            // 
            // rdoGovenment
            // 
            this.rdoGovenment.AutoSize = true;
            this.rdoGovenment.Location = new System.Drawing.Point(138, 3);
            this.rdoGovenment.Name = "rdoGovenment";
            this.rdoGovenment.Size = new System.Drawing.Size(49, 17);
            this.rdoGovenment.TabIndex = 2;
            this.rdoGovenment.Text = "文官";
            this.rdoGovenment.UseVisualStyleBackColor = true;
            this.rdoGovenment.CheckedChanged += new System.EventHandler(this.rdoGovenment_CheckedChanged);
            // 
            // rdoArmy
            // 
            this.rdoArmy.AutoSize = true;
            this.rdoArmy.Location = new System.Drawing.Point(207, 3);
            this.rdoArmy.Name = "rdoArmy";
            this.rdoArmy.Size = new System.Drawing.Size(49, 17);
            this.rdoArmy.TabIndex = 3;
            this.rdoArmy.Text = "武将";
            this.rdoArmy.UseVisualStyleBackColor = true;
            this.rdoArmy.CheckedChanged += new System.EventHandler(this.rdoArmy_CheckedChanged);
            // 
            // lblCongratulation
            // 
            this.lblCongratulation.AutoSize = true;
            this.lblCongratulation.Location = new System.Drawing.Point(83, 472);
            this.lblCongratulation.Name = "lblCongratulation";
            this.lblCongratulation.Size = new System.Drawing.Size(124, 13);
            this.lblCongratulation.TabIndex = 6;
            this.lblCongratulation.Text = "GREAT! You are TOP 1.";
            // 
            // btnUp
            // 
            this.btnUp.Location = new System.Drawing.Point(116, 398);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(58, 33);
            this.btnUp.TabIndex = 7;
            this.btnUp.Text = "Up";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnRight
            // 
            this.btnRight.Location = new System.Drawing.Point(172, 429);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(58, 33);
            this.btnRight.TabIndex = 8;
            this.btnRight.Text = "Right";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // btnDown
            // 
            this.btnDown.Location = new System.Drawing.Point(116, 429);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(58, 33);
            this.btnDown.TabIndex = 9;
            this.btnDown.Text = "Down";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.Location = new System.Drawing.Point(62, 429);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(58, 33);
            this.btnLeft.TabIndex = 10;
            this.btnLeft.Text = "Left";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 497);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.lblCongratulation);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblHighScoreLabel);
            this.Controls.Add(this.lblHighScore);
            this.Controls.Add(this.lblScoreLabel);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.pnlBoard);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlBoard;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblScoreLabel;
        private System.Windows.Forms.Label lblHighScoreLabel;
        private System.Windows.Forms.Label lblHighScore;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rdoArmy;
        private System.Windows.Forms.RadioButton rdoGovenment;
        private System.Windows.Forms.RadioButton rdoDynasty;
        private System.Windows.Forms.RadioButton rdonumber;
        private System.Windows.Forms.Label lblCongratulation;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnLeft;
    }
}

