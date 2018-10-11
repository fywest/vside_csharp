using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace drawTree
{
    public partial class Form2 : Form
    {
        Form1 form1 = new Form1();
        String txtinput;
        public Form2()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.Manual; //A
            this.Location = new Point(100, 0); //B
            form1.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            form1.Invalidate();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtper1_TextChanged(object sender, EventArgs e)
        {
            //txtinput = txtper1.Text;

        }

        private void txtper1_Validated(object sender, EventArgs e)
        {
            double number;
            txtinput = txtper1.Text;
            bool result = double.TryParse(txtinput, out number);
            if (result)
            {
                form1.per1 = number;
                lblinfo.Text = txtinput + " update successful!";
            }
            else
            {
                lblinfo.Text = txtinput+" invalid input and please check!";
            }
        }

        private void txtper2_Validated(object sender, EventArgs e)
        {
            double number;
            txtinput = txtper2.Text;
            bool result = double.TryParse(txtinput, out number);
            if (result)
            {
                form1.per2 = number;
                lblinfo.Text = txtinput + " update successful!";
            }
            else
            {
                lblinfo.Text = txtinput + " invalid input and please check!";
            }
        }

        private void txtAngle1_Validated(object sender, EventArgs e)
        {
            int number;
            txtinput = txtAngle1.Text;
            bool result = Int32.TryParse(txtinput, out number);
            if (result)
            {

                form1.th1 = number * Math.PI / 180;
                lblinfo.Text = txtinput + " update successful!";
            }
            else
            {
                lblinfo.Text = txtinput + " invalid input and please check!";
            }
        }

        private void txtAngle2_Validated(object sender, EventArgs e)
        {
            int number;
            txtinput = txtAngle2.Text;
            bool result = Int32.TryParse(txtinput, out number);
            if (result)
            {

                form1.th2 = number * Math.PI / 180;
                lblinfo.Text = txtinput + " update successful!";
            }
            else
            {
                lblinfo.Text = txtinput + " invalid input and please check!";
            }
        }


        private void listColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            form1.color=listColor.SelectedItem.ToString();
        }


        private void listPenWidth_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            double number;
            txtinput = listPenWidth.SelectedItem.ToString();
            bool result = double.TryParse(txtinput, out number);
            if (result)
            {
                form1.width = number;
                lblinfo.Text = txtinput + " update successful!";
            }
            else
            {
                lblinfo.Text = txtinput + " invalid input and please check!";
            }
        }

        private void txtK_Validated(object sender, EventArgs e)
        {
            double number;
            txtinput = txtK.Text;
            bool result = double.TryParse(txtinput, out number);
            if (result)
            {

                form1.k = number;
                lblinfo.Text = txtinput + " update successful!";
            }
            else
            {
                lblinfo.Text = txtinput + " invalid input and please check!";
            }
        }



        private void chkRndEnable_CheckedChanged(object sender, EventArgs e)
        {
            if (chkRndEnable.Checked == true)
            {
                form1.isRandom = true;
            }
            else
            {
                form1.isRandom = false;
            }
        }
    }
}
