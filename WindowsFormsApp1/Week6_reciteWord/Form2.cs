using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace reciteWord1
{

    public partial class Form2 : Form
    {

        public static WordLibrary library = new WordLibrary("College_Grade4");

        public Form2()
        {
            InitializeComponent();

            library.ReadFile();
            lblAmount.Text = "累计学习单词 ";
            lblDuration.Text = "累计学习时间 ";
            lblCorrect.Text = "已经记忆单词 ";
        }

        private void btnLearn_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();


        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            Form1 form1=new Form1();
            form1.Show();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblAmount.Text = "累计学习单词 "+Form3.amount.ToString()+" 个";
            lblDuration.Text = "累计学习时间 "+Form3.duration.ToString()+" 秒";
            lblCorrect.Text = "已经记忆单词 " + Form4.remember.ToString() + " 个";
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
        }
    }
}
