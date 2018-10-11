namespace week2自动出题并判分的改进
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
            this.components = new System.ComponentModel.Container();
            this.grpNumRange = new System.Windows.Forms.GroupBox();
            this.radbtn100 = new System.Windows.Forms.RadioButton();
            this.radbtn20 = new System.Windows.Forms.RadioButton();
            this.radbtn10 = new System.Windows.Forms.RadioButton();
            this.chkDispNext = new System.Windows.Forms.CheckBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnFast = new System.Windows.Forms.Button();
            this.btnSlow = new System.Windows.Forms.Button();
            this.chkDispAnswer = new System.Windows.Forms.CheckBox();
            this.lstDisp = new System.Windows.Forms.ListBox();
            this.lblA = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblB = new System.Windows.Forms.Label();
            this.lblOp = new System.Windows.Forms.Label();
            this.lblEqual = new System.Windows.Forms.Label();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.grpOpmode = new System.Windows.Forms.GroupBox();
            this.radbtnDiv = new System.Windows.Forms.RadioButton();
            this.radbtnMul = new System.Windows.Forms.RadioButton();
            this.radbtnMinus = new System.Windows.Forms.RadioButton();
            this.radbtnAdd = new System.Windows.Forms.RadioButton();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnNum1 = new System.Windows.Forms.Button();
            this.btnNum2 = new System.Windows.Forms.Button();
            this.btnNum3 = new System.Windows.Forms.Button();
            this.btnNum4 = new System.Windows.Forms.Button();
            this.btnNum5 = new System.Windows.Forms.Button();
            this.btnNum6 = new System.Windows.Forms.Button();
            this.btnNum7 = new System.Windows.Forms.Button();
            this.btnNum8 = new System.Windows.Forms.Button();
            this.btnNum9 = new System.Windows.Forms.Button();
            this.btnNum0 = new System.Windows.Forms.Button();
            this.btnKeyReset = new System.Windows.Forms.Button();
            this.lblSecShow = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.grpNumRange.SuspendLayout();
            this.grpOpmode.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpNumRange
            // 
            this.grpNumRange.Controls.Add(this.radbtn100);
            this.grpNumRange.Controls.Add(this.radbtn20);
            this.grpNumRange.Controls.Add(this.radbtn10);
            this.grpNumRange.Location = new System.Drawing.Point(24, 24);
            this.grpNumRange.Name = "grpNumRange";
            this.grpNumRange.Size = new System.Drawing.Size(255, 52);
            this.grpNumRange.TabIndex = 0;
            this.grpNumRange.TabStop = false;
            this.grpNumRange.Text = "数字范围";
            // 
            // radbtn100
            // 
            this.radbtn100.AutoSize = true;
            this.radbtn100.Location = new System.Drawing.Point(126, 19);
            this.radbtn100.Name = "radbtn100";
            this.radbtn100.Size = new System.Drawing.Size(67, 17);
            this.radbtn100.TabIndex = 2;
            this.radbtn100.TabStop = true;
            this.radbtn100.Text = "100以内";
            this.radbtn100.UseVisualStyleBackColor = true;
            // 
            // radbtn20
            // 
            this.radbtn20.AutoSize = true;
            this.radbtn20.Location = new System.Drawing.Point(66, 20);
            this.radbtn20.Name = "radbtn20";
            this.radbtn20.Size = new System.Drawing.Size(61, 17);
            this.radbtn20.TabIndex = 1;
            this.radbtn20.TabStop = true;
            this.radbtn20.Text = "20以内";
            this.radbtn20.UseVisualStyleBackColor = true;
            // 
            // radbtn10
            // 
            this.radbtn10.AutoSize = true;
            this.radbtn10.Location = new System.Drawing.Point(7, 20);
            this.radbtn10.Name = "radbtn10";
            this.radbtn10.Size = new System.Drawing.Size(61, 17);
            this.radbtn10.TabIndex = 0;
            this.radbtn10.TabStop = true;
            this.radbtn10.Text = "10以内";
            this.radbtn10.UseVisualStyleBackColor = true;
            // 
            // chkDispNext
            // 
            this.chkDispNext.AutoSize = true;
            this.chkDispNext.Location = new System.Drawing.Point(297, 44);
            this.chkDispNext.Name = "chkDispNext";
            this.chkDispNext.Size = new System.Drawing.Size(110, 17);
            this.chkDispNext.TabIndex = 1;
            this.chkDispNext.Text = "自动显示下一题";
            this.chkDispNext.UseVisualStyleBackColor = true;
            this.chkDispNext.CheckedChanged += new System.EventHandler(this.chkDispNext_CheckedChanged);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(297, 68);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = "下一题";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnFast
            // 
            this.btnFast.Location = new System.Drawing.Point(413, 40);
            this.btnFast.Name = "btnFast";
            this.btnFast.Size = new System.Drawing.Size(75, 23);
            this.btnFast.TabIndex = 3;
            this.btnFast.Text = "快些";
            this.btnFast.UseVisualStyleBackColor = true;
            this.btnFast.Click += new System.EventHandler(this.btnFast_Click);
            // 
            // btnSlow
            // 
            this.btnSlow.Location = new System.Drawing.Point(494, 40);
            this.btnSlow.Name = "btnSlow";
            this.btnSlow.Size = new System.Drawing.Size(75, 23);
            this.btnSlow.TabIndex = 4;
            this.btnSlow.Text = "慢些";
            this.btnSlow.UseVisualStyleBackColor = true;
            this.btnSlow.Click += new System.EventHandler(this.btnSlow_Click);
            // 
            // chkDispAnswer
            // 
            this.chkDispAnswer.AutoSize = true;
            this.chkDispAnswer.Location = new System.Drawing.Point(414, 74);
            this.chkDispAnswer.Name = "chkDispAnswer";
            this.chkDispAnswer.Size = new System.Drawing.Size(98, 17);
            this.chkDispAnswer.TabIndex = 5;
            this.chkDispAnswer.Text = "自动显示答案";
            this.chkDispAnswer.UseVisualStyleBackColor = true;
            this.chkDispAnswer.CheckedChanged += new System.EventHandler(this.chkDispAnswer_CheckedChanged);
            this.chkDispAnswer.Click += new System.EventHandler(this.chkDispAnswer_Click);
            // 
            // lstDisp
            // 
            this.lstDisp.FormattingEnabled = true;
            this.lstDisp.Location = new System.Drawing.Point(414, 105);
            this.lstDisp.Name = "lstDisp";
            this.lstDisp.Size = new System.Drawing.Size(157, 173);
            this.lstDisp.TabIndex = 6;
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblA.Location = new System.Drawing.Point(-3, 139);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(68, 73);
            this.lblA.TabIndex = 7;
            this.lblA.Text = "1";
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblB.Location = new System.Drawing.Point(137, 139);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(68, 73);
            this.lblB.TabIndex = 8;
            this.lblB.Text = "2";
            // 
            // lblOp
            // 
            this.lblOp.AutoSize = true;
            this.lblOp.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOp.Location = new System.Drawing.Point(82, 139);
            this.lblOp.Name = "lblOp";
            this.lblOp.Size = new System.Drawing.Size(69, 73);
            this.lblOp.TabIndex = 9;
            this.lblOp.Text = "+";
            // 
            // lblEqual
            // 
            this.lblEqual.AutoSize = true;
            this.lblEqual.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEqual.Location = new System.Drawing.Point(223, 142);
            this.lblEqual.Name = "lblEqual";
            this.lblEqual.Size = new System.Drawing.Size(69, 73);
            this.lblEqual.TabIndex = 10;
            this.lblEqual.Text = "=";
            // 
            // txtAnswer
            // 
            this.txtAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnswer.Location = new System.Drawing.Point(282, 135);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(125, 80);
            this.txtAnswer.TabIndex = 11;
            this.txtAnswer.Text = "3";
            this.txtAnswer.Click += new System.EventHandler(this.txtAnswer_Click);
            this.txtAnswer.TextChanged += new System.EventHandler(this.txtAnswer_TextChanged);
            // 
            // grpOpmode
            // 
            this.grpOpmode.Controls.Add(this.radbtnDiv);
            this.grpOpmode.Controls.Add(this.radbtnMul);
            this.grpOpmode.Controls.Add(this.radbtnMinus);
            this.grpOpmode.Controls.Add(this.radbtnAdd);
            this.grpOpmode.Location = new System.Drawing.Point(24, 82);
            this.grpOpmode.Name = "grpOpmode";
            this.grpOpmode.Size = new System.Drawing.Size(255, 52);
            this.grpOpmode.TabIndex = 12;
            this.grpOpmode.TabStop = false;
            this.grpOpmode.Text = "运算类型";
            // 
            // radbtnDiv
            // 
            this.radbtnDiv.AutoSize = true;
            this.radbtnDiv.Location = new System.Drawing.Point(191, 20);
            this.radbtnDiv.Name = "radbtnDiv";
            this.radbtnDiv.Size = new System.Drawing.Size(37, 17);
            this.radbtnDiv.TabIndex = 3;
            this.radbtnDiv.TabStop = true;
            this.radbtnDiv.Text = "除";
            this.radbtnDiv.UseVisualStyleBackColor = true;
            // 
            // radbtnMul
            // 
            this.radbtnMul.AutoSize = true;
            this.radbtnMul.Location = new System.Drawing.Point(126, 20);
            this.radbtnMul.Name = "radbtnMul";
            this.radbtnMul.Size = new System.Drawing.Size(37, 17);
            this.radbtnMul.TabIndex = 2;
            this.radbtnMul.TabStop = true;
            this.radbtnMul.Text = "乘";
            this.radbtnMul.UseVisualStyleBackColor = true;
            // 
            // radbtnMinus
            // 
            this.radbtnMinus.AutoSize = true;
            this.radbtnMinus.Location = new System.Drawing.Point(66, 19);
            this.radbtnMinus.Name = "radbtnMinus";
            this.radbtnMinus.Size = new System.Drawing.Size(37, 17);
            this.radbtnMinus.TabIndex = 1;
            this.radbtnMinus.TabStop = true;
            this.radbtnMinus.Text = "减";
            this.radbtnMinus.UseVisualStyleBackColor = true;
            // 
            // radbtnAdd
            // 
            this.radbtnAdd.AutoSize = true;
            this.radbtnAdd.Location = new System.Drawing.Point(7, 20);
            this.radbtnAdd.Name = "radbtnAdd";
            this.radbtnAdd.Size = new System.Drawing.Size(37, 17);
            this.radbtnAdd.TabIndex = 0;
            this.radbtnAdd.TabStop = true;
            this.radbtnAdd.Text = "加";
            this.radbtnAdd.UseVisualStyleBackColor = true;
            this.radbtnAdd.Click += new System.EventHandler(this.radbtnAdd_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(297, 101);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 13;
            this.btnConfirm.Text = "确定";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnNum1
            // 
            this.btnNum1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNum1.Location = new System.Drawing.Point(53, 244);
            this.btnNum1.Name = "btnNum1";
            this.btnNum1.Size = new System.Drawing.Size(34, 34);
            this.btnNum1.TabIndex = 14;
            this.btnNum1.Text = "1";
            this.btnNum1.UseVisualStyleBackColor = true;
            this.btnNum1.Click += new System.EventHandler(this.btnNum1_Click);
            // 
            // btnNum2
            // 
            this.btnNum2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNum2.Location = new System.Drawing.Point(93, 244);
            this.btnNum2.Name = "btnNum2";
            this.btnNum2.Size = new System.Drawing.Size(34, 34);
            this.btnNum2.TabIndex = 15;
            this.btnNum2.Text = "2";
            this.btnNum2.UseVisualStyleBackColor = true;
            this.btnNum2.Click += new System.EventHandler(this.btnNum2_Click);
            // 
            // btnNum3
            // 
            this.btnNum3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNum3.Location = new System.Drawing.Point(133, 244);
            this.btnNum3.Name = "btnNum3";
            this.btnNum3.Size = new System.Drawing.Size(34, 34);
            this.btnNum3.TabIndex = 16;
            this.btnNum3.Text = "3";
            this.btnNum3.UseVisualStyleBackColor = true;
            this.btnNum3.Click += new System.EventHandler(this.btnNum3_Click);
            // 
            // btnNum4
            // 
            this.btnNum4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNum4.Location = new System.Drawing.Point(173, 244);
            this.btnNum4.Name = "btnNum4";
            this.btnNum4.Size = new System.Drawing.Size(34, 34);
            this.btnNum4.TabIndex = 17;
            this.btnNum4.Text = "4";
            this.btnNum4.UseVisualStyleBackColor = true;
            this.btnNum4.Click += new System.EventHandler(this.btnNum4_Click);
            // 
            // btnNum5
            // 
            this.btnNum5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNum5.Location = new System.Drawing.Point(213, 244);
            this.btnNum5.Name = "btnNum5";
            this.btnNum5.Size = new System.Drawing.Size(34, 34);
            this.btnNum5.TabIndex = 18;
            this.btnNum5.Text = "5";
            this.btnNum5.UseVisualStyleBackColor = true;
            this.btnNum5.Click += new System.EventHandler(this.btnNum5_Click);
            // 
            // btnNum6
            // 
            this.btnNum6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNum6.Location = new System.Drawing.Point(253, 244);
            this.btnNum6.Name = "btnNum6";
            this.btnNum6.Size = new System.Drawing.Size(34, 34);
            this.btnNum6.TabIndex = 19;
            this.btnNum6.Text = "6";
            this.btnNum6.UseVisualStyleBackColor = true;
            this.btnNum6.Click += new System.EventHandler(this.btnNum6_Click);
            // 
            // btnNum7
            // 
            this.btnNum7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNum7.Location = new System.Drawing.Point(293, 244);
            this.btnNum7.Name = "btnNum7";
            this.btnNum7.Size = new System.Drawing.Size(34, 34);
            this.btnNum7.TabIndex = 20;
            this.btnNum7.Text = "7";
            this.btnNum7.UseVisualStyleBackColor = true;
            this.btnNum7.Click += new System.EventHandler(this.btnNum7_Click);
            // 
            // btnNum8
            // 
            this.btnNum8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNum8.Location = new System.Drawing.Point(333, 244);
            this.btnNum8.Name = "btnNum8";
            this.btnNum8.Size = new System.Drawing.Size(34, 34);
            this.btnNum8.TabIndex = 21;
            this.btnNum8.Text = "8";
            this.btnNum8.UseVisualStyleBackColor = true;
            this.btnNum8.Click += new System.EventHandler(this.btnNum8_Click);
            // 
            // btnNum9
            // 
            this.btnNum9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNum9.Location = new System.Drawing.Point(373, 244);
            this.btnNum9.Name = "btnNum9";
            this.btnNum9.Size = new System.Drawing.Size(34, 34);
            this.btnNum9.TabIndex = 22;
            this.btnNum9.Text = "9";
            this.btnNum9.UseVisualStyleBackColor = true;
            this.btnNum9.Click += new System.EventHandler(this.btnNum9_Click);
            // 
            // btnNum0
            // 
            this.btnNum0.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNum0.Location = new System.Drawing.Point(13, 244);
            this.btnNum0.Name = "btnNum0";
            this.btnNum0.Size = new System.Drawing.Size(34, 34);
            this.btnNum0.TabIndex = 23;
            this.btnNum0.Text = "0";
            this.btnNum0.UseVisualStyleBackColor = true;
            this.btnNum0.Click += new System.EventHandler(this.btnNum0_Click);
            // 
            // btnKeyReset
            // 
            this.btnKeyReset.Location = new System.Drawing.Point(293, 218);
            this.btnKeyReset.Name = "btnKeyReset";
            this.btnKeyReset.Size = new System.Drawing.Size(92, 23);
            this.btnKeyReset.TabIndex = 25;
            this.btnKeyReset.Text = "数字输入重置";
            this.btnKeyReset.UseVisualStyleBackColor = true;
            this.btnKeyReset.Click += new System.EventHandler(this.btnKeyReset_Click);
            // 
            // lblSecShow
            // 
            this.lblSecShow.AutoSize = true;
            this.lblSecShow.Location = new System.Drawing.Point(514, 75);
            this.lblSecShow.Name = "lblSecShow";
            this.lblSecShow.Size = new System.Drawing.Size(55, 13);
            this.lblSecShow.TabIndex = 26;
            this.lblSecShow.Text = "剩余 0 秒";
            this.lblSecShow.Visible = false;
            this.lblSecShow.Click += new System.EventHandler(this.lblSecShow_Click);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 307);
            this.Controls.Add(this.lblSecShow);
            this.Controls.Add(this.btnKeyReset);
            this.Controls.Add(this.btnNum0);
            this.Controls.Add(this.btnNum9);
            this.Controls.Add(this.btnNum8);
            this.Controls.Add(this.btnNum7);
            this.Controls.Add(this.btnNum6);
            this.Controls.Add(this.btnNum5);
            this.Controls.Add(this.btnNum4);
            this.Controls.Add(this.btnNum3);
            this.Controls.Add(this.btnNum2);
            this.Controls.Add(this.btnNum1);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.grpOpmode);
            this.Controls.Add(this.txtAnswer);
            this.Controls.Add(this.lblEqual);
            this.Controls.Add(this.lblOp);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.lstDisp);
            this.Controls.Add(this.chkDispAnswer);
            this.Controls.Add(this.btnSlow);
            this.Controls.Add(this.btnFast);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.chkDispNext);
            this.Controls.Add(this.grpNumRange);
            this.Name = "Form1";
            this.Text = "算术练习";
            this.grpNumRange.ResumeLayout(false);
            this.grpNumRange.PerformLayout();
            this.grpOpmode.ResumeLayout(false);
            this.grpOpmode.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpNumRange;
        private System.Windows.Forms.RadioButton radbtn100;
        private System.Windows.Forms.RadioButton radbtn20;
        private System.Windows.Forms.RadioButton radbtn10;
        private System.Windows.Forms.CheckBox chkDispNext;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnFast;
        private System.Windows.Forms.Button btnSlow;
        private System.Windows.Forms.CheckBox chkDispAnswer;
        private System.Windows.Forms.ListBox lstDisp;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Label lblOp;
        private System.Windows.Forms.Label lblEqual;
        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.GroupBox grpOpmode;
        private System.Windows.Forms.RadioButton radbtnDiv;
        private System.Windows.Forms.RadioButton radbtnMul;
        private System.Windows.Forms.RadioButton radbtnMinus;
        private System.Windows.Forms.RadioButton radbtnAdd;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnNum1;
        private System.Windows.Forms.Button btnNum2;
        private System.Windows.Forms.Button btnNum3;
        private System.Windows.Forms.Button btnNum4;
        private System.Windows.Forms.Button btnNum5;
        private System.Windows.Forms.Button btnNum6;
        private System.Windows.Forms.Button btnNum7;
        private System.Windows.Forms.Button btnNum8;
        private System.Windows.Forms.Button btnNum9;
        private System.Windows.Forms.Button btnNum0;
        private System.Windows.Forms.Button btnKeyReset;
        private System.Windows.Forms.Label lblSecShow;
        private System.Windows.Forms.Timer timer2;
    }
}

