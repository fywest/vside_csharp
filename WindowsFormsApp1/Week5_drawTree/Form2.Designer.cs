namespace drawTree
{
    partial class Form2
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
            this.btnDraw = new System.Windows.Forms.Button();
            this.lblper1 = new System.Windows.Forms.Label();
            this.txtper1 = new System.Windows.Forms.TextBox();
            this.lblinfo = new System.Windows.Forms.Label();
            this.txtper2 = new System.Windows.Forms.TextBox();
            this.lblper2 = new System.Windows.Forms.Label();
            this.txtAngle2 = new System.Windows.Forms.TextBox();
            this.lblAngle2 = new System.Windows.Forms.Label();
            this.txtAngle1 = new System.Windows.Forms.TextBox();
            this.lblAngle1 = new System.Windows.Forms.Label();
            this.lblPenWidth = new System.Windows.Forms.Label();
            this.lblPenColor = new System.Windows.Forms.Label();
            this.listColor = new System.Windows.Forms.ListBox();
            this.listPenWidth = new System.Windows.Forms.ListBox();
            this.txtK = new System.Windows.Forms.TextBox();
            this.lblk = new System.Windows.Forms.Label();
            this.chkRndEnable = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnDraw
            // 
            this.btnDraw.Location = new System.Drawing.Point(110, 281);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(100, 20);
            this.btnDraw.TabIndex = 0;
            this.btnDraw.Text = "Draw Tree";
            this.btnDraw.UseVisualStyleBackColor = true;
            this.btnDraw.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblper1
            // 
            this.lblper1.AutoSize = true;
            this.lblper1.Location = new System.Drawing.Point(46, 81);
            this.lblper1.Name = "lblper1";
            this.lblper1.Size = new System.Drawing.Size(28, 13);
            this.lblper1.TabIndex = 2;
            this.lblper1.Text = "per1";
            // 
            // txtper1
            // 
            this.txtper1.Location = new System.Drawing.Point(110, 74);
            this.txtper1.Name = "txtper1";
            this.txtper1.Size = new System.Drawing.Size(100, 20);
            this.txtper1.TabIndex = 3;
            this.txtper1.Text = "0.6";
            this.txtper1.TextChanged += new System.EventHandler(this.txtper1_TextChanged);
            this.txtper1.Validated += new System.EventHandler(this.txtper1_Validated);
            // 
            // lblinfo
            // 
            this.lblinfo.AutoSize = true;
            this.lblinfo.Location = new System.Drawing.Point(107, 353);
            this.lblinfo.Name = "lblinfo";
            this.lblinfo.Size = new System.Drawing.Size(58, 13);
            this.lblinfo.TabIndex = 4;
            this.lblinfo.Text = "information";
            // 
            // txtper2
            // 
            this.txtper2.Location = new System.Drawing.Point(110, 109);
            this.txtper2.Name = "txtper2";
            this.txtper2.Size = new System.Drawing.Size(100, 20);
            this.txtper2.TabIndex = 5;
            this.txtper2.Text = "0.7";
            this.txtper2.Validated += new System.EventHandler(this.txtper2_Validated);
            // 
            // lblper2
            // 
            this.lblper2.AutoSize = true;
            this.lblper2.Location = new System.Drawing.Point(46, 112);
            this.lblper2.Name = "lblper2";
            this.lblper2.Size = new System.Drawing.Size(28, 13);
            this.lblper2.TabIndex = 6;
            this.lblper2.Text = "per2";
            // 
            // txtAngle2
            // 
            this.txtAngle2.Location = new System.Drawing.Point(110, 40);
            this.txtAngle2.Name = "txtAngle2";
            this.txtAngle2.Size = new System.Drawing.Size(100, 20);
            this.txtAngle2.TabIndex = 7;
            this.txtAngle2.Text = "25";
            this.txtAngle2.Validated += new System.EventHandler(this.txtAngle2_Validated);
            // 
            // lblAngle2
            // 
            this.lblAngle2.AutoSize = true;
            this.lblAngle2.Location = new System.Drawing.Point(46, 47);
            this.lblAngle2.Name = "lblAngle2";
            this.lblAngle2.Size = new System.Drawing.Size(39, 13);
            this.lblAngle2.TabIndex = 8;
            this.lblAngle2.Text = "angle2";
            // 
            // txtAngle1
            // 
            this.txtAngle1.Location = new System.Drawing.Point(110, 9);
            this.txtAngle1.Name = "txtAngle1";
            this.txtAngle1.Size = new System.Drawing.Size(100, 20);
            this.txtAngle1.TabIndex = 9;
            this.txtAngle1.Text = "35";
            this.txtAngle1.Validated += new System.EventHandler(this.txtAngle1_Validated);
            // 
            // lblAngle1
            // 
            this.lblAngle1.AutoSize = true;
            this.lblAngle1.Location = new System.Drawing.Point(46, 16);
            this.lblAngle1.Name = "lblAngle1";
            this.lblAngle1.Size = new System.Drawing.Size(39, 13);
            this.lblAngle1.TabIndex = 10;
            this.lblAngle1.Text = "angle1";
            // 
            // lblPenWidth
            // 
            this.lblPenWidth.AutoSize = true;
            this.lblPenWidth.Location = new System.Drawing.Point(44, 228);
            this.lblPenWidth.Name = "lblPenWidth";
            this.lblPenWidth.Size = new System.Drawing.Size(53, 13);
            this.lblPenWidth.TabIndex = 12;
            this.lblPenWidth.Text = "pen width";
            // 
            // lblPenColor
            // 
            this.lblPenColor.AutoSize = true;
            this.lblPenColor.Location = new System.Drawing.Point(46, 176);
            this.lblPenColor.Name = "lblPenColor";
            this.lblPenColor.Size = new System.Drawing.Size(51, 13);
            this.lblPenColor.TabIndex = 14;
            this.lblPenColor.Text = "pen color";
            // 
            // listColor
            // 
            this.listColor.FormattingEnabled = true;
            this.listColor.Items.AddRange(new object[] {
            "blue",
            "red",
            "green",
            "pink",
            "violet",
            "yellow"});
            this.listColor.Location = new System.Drawing.Point(110, 176);
            this.listColor.Name = "listColor";
            this.listColor.Size = new System.Drawing.Size(100, 30);
            this.listColor.TabIndex = 15;
            this.listColor.SelectedIndexChanged += new System.EventHandler(this.listColor_SelectedIndexChanged);
            // 
            // listPenWidth
            // 
            this.listPenWidth.FormattingEnabled = true;
            this.listPenWidth.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.listPenWidth.Location = new System.Drawing.Point(110, 228);
            this.listPenWidth.Name = "listPenWidth";
            this.listPenWidth.Size = new System.Drawing.Size(100, 30);
            this.listPenWidth.TabIndex = 16;
            this.listPenWidth.SelectedIndexChanged += new System.EventHandler(this.listPenWidth_SelectedIndexChanged);
            // 
            // txtK
            // 
            this.txtK.Location = new System.Drawing.Point(110, 145);
            this.txtK.Name = "txtK";
            this.txtK.Size = new System.Drawing.Size(100, 20);
            this.txtK.TabIndex = 17;
            this.txtK.Text = "2";
            this.txtK.Validated += new System.EventHandler(this.txtK_Validated);
            // 
            // lblk
            // 
            this.lblk.AutoSize = true;
            this.lblk.Location = new System.Drawing.Point(49, 151);
            this.lblk.Name = "lblk";
            this.lblk.Size = new System.Drawing.Size(42, 13);
            this.lblk.TabIndex = 18;
            this.lblk.Text = "k value";
            // 
            // chkRndEnable
            // 
            this.chkRndEnable.AutoSize = true;
            this.chkRndEnable.Checked = true;
            this.chkRndEnable.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkRndEnable.Location = new System.Drawing.Point(110, 319);
            this.chkRndEnable.Name = "chkRndEnable";
            this.chkRndEnable.Size = new System.Drawing.Size(66, 17);
            this.chkRndEnable.TabIndex = 19;
            this.chkRndEnable.Text = "Random";
            this.chkRndEnable.UseVisualStyleBackColor = true;
            this.chkRndEnable.CheckedChanged += new System.EventHandler(this.chkRndEnable_CheckedChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 375);
            this.Controls.Add(this.chkRndEnable);
            this.Controls.Add(this.lblk);
            this.Controls.Add(this.txtK);
            this.Controls.Add(this.listPenWidth);
            this.Controls.Add(this.listColor);
            this.Controls.Add(this.lblPenColor);
            this.Controls.Add(this.lblPenWidth);
            this.Controls.Add(this.lblAngle1);
            this.Controls.Add(this.txtAngle1);
            this.Controls.Add(this.lblAngle2);
            this.Controls.Add(this.txtAngle2);
            this.Controls.Add(this.lblper2);
            this.Controls.Add(this.txtper2);
            this.Controls.Add(this.lblinfo);
            this.Controls.Add(this.txtper1);
            this.Controls.Add(this.lblper1);
            this.Controls.Add(this.btnDraw);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDraw;
        private System.Windows.Forms.Label lblper1;
        private System.Windows.Forms.TextBox txtper1;
        private System.Windows.Forms.Label lblinfo;
        private System.Windows.Forms.TextBox txtper2;
        private System.Windows.Forms.Label lblper2;
        private System.Windows.Forms.TextBox txtAngle2;
        private System.Windows.Forms.Label lblAngle2;
        private System.Windows.Forms.TextBox txtAngle1;
        private System.Windows.Forms.Label lblAngle1;
        private System.Windows.Forms.Label lblPenWidth;
        private System.Windows.Forms.Label lblPenColor;
        private System.Windows.Forms.ListBox listColor;
        private System.Windows.Forms.ListBox listPenWidth;
        private System.Windows.Forms.TextBox txtK;
        private System.Windows.Forms.Label lblk;
        private System.Windows.Forms.CheckBox chkRndEnable;
    }
}