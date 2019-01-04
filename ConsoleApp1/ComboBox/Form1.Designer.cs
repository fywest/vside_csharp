namespace ComboBox
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
            this.addButton = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.addGrandButton = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.showSelectedButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.findButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(248, 32);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(64, 43);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "Add";
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(8, 100);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(232, 35);
            this.textBox2.TabIndex = 6;
            // 
            // addGrandButton
            // 
            this.addGrandButton.Location = new System.Drawing.Point(8, 168);
            this.addGrandButton.Name = "addGrandButton";
            this.addGrandButton.Size = new System.Drawing.Size(280, 34);
            this.addGrandButton.TabIndex = 2;
            this.addGrandButton.Text = "Add 1,000 Items";
            this.addGrandButton.Click += new System.EventHandler(this.addGrandButton_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.DropDownWidth = 280;
            this.comboBox1.Items.AddRange(new object[] {
            "Item 1",
            "Item 2",
            "Item 3",
            "Item 4",
            "Item 5"});
            this.comboBox1.Location = new System.Drawing.Point(8, 508);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(390, 32);
            this.comboBox1.TabIndex = 7;
            // 
            // showSelectedButton
            // 
            this.showSelectedButton.Location = new System.Drawing.Point(8, 234);
            this.showSelectedButton.Name = "showSelectedButton";
            this.showSelectedButton.Size = new System.Drawing.Size(280, 38);
            this.showSelectedButton.TabIndex = 4;
            this.showSelectedButton.Text = "What Item is Selected?";
            this.showSelectedButton.Click += new System.EventHandler(this.showSelectedButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(8, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(232, 35);
            this.textBox1.TabIndex = 5;
            // 
            // findButton
            // 
            this.findButton.Location = new System.Drawing.Point(248, 100);
            this.findButton.Name = "findButton";
            this.findButton.Size = new System.Drawing.Size(70, 46);
            this.findButton.TabIndex = 3;
            this.findButton.Text = "Find";
            this.findButton.Click += new System.EventHandler(this.findButton_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 300);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Test ComboBox";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 579);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.showSelectedButton);
            this.Controls.Add(this.findButton);
            this.Controls.Add(this.addGrandButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "ComboBox Sample";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}

