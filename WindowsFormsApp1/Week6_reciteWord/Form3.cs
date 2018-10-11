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
    public partial class Form3 : Form
    {
        static int number = 0;
        public static int amount = 0;
        public static int duration = 0;
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            lblCh.Text = "单词";
            lblEn.Text = "word";
            timer1.Interval = 1000;
            if (rdoRandom.Checked == true)
            {

                btnStart.Text = "pause";
                timer1.Enabled = true;
            }
        }



        void showWord()
        {
            Word word = Form2.library.wordlist[number];
            lblCh.Text = word._chinese;
            lblEn.Text = word._english;
            amount++;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if(rdoRandom.Checked==true|| rdoLoop.Checked == true)
            {
                
                if (btnStart.Text == "pause")
                {
                    timer1.Enabled = false;
                    //timer1.Interval = 1000;
                    btnStart.Text = "continue";

                }
                else if(btnStart.Text == "continue")
                {
                    timer1.Enabled = true;
                    btnStart.Text = "pause";

                }

            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            number++;
            showWord();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {

            if (number > 0)
                number--;
            showWord();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(rdoRandom.Checked==true)
            {
                number = randomNum();
            }
            else
            {
                number++;
            }

            showWord();
        }

        public static int randomNum()
        {
            int len = Form2.library.wordlist.Count();
            Random ran = new Random();
            int RandKey = ran.Next(1,len );
            return RandKey;

        }

        private void trbTimer_ValueChanged(object sender, EventArgs e)
        {
            timer1.Interval = 100*trbTimer.Value;
            lblSpeed.Text = "Speed(mS)"+timer1.Interval.ToString();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            duration++;
            
        }
    }
}
