using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week1_task
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {

                    
           msec++;
            if(msec==100)
            {
                sec++;
                msec = 0;
                if(sec==60)
                {
                    min++;
                    sec = 0;
                    if(min==60)
                    {
                        min = 0;
                    }

                }
            }

            label1.Text = string.Format("{0:00}", min) + " : " + string.Format("{0:00}", sec) + " : " + string.Format("{0:00}", msec);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void stop_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.min = 0;
            this.sec = 0;
            this.msec = 0;
            label1.Text = string.Format("{0:00}", min) + " : " + string.Format("{0:00}", sec) + " : " + string.Format("{0:00}", msec);
        }
    }
}
