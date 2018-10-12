using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace week2自动出题并判分的改进
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            radbtn10.Checked = true;
            radbtnAdd.Checked = true;
            lstDisp.Items.Add("good luck !");
           
        }

        int a=1, b=2;
        string op="+";
        string str = "";
        string txtInput = "3";
        string disp = "";
        int result=3;
        bool keyFirst =true;
        int keyinput=0;
        int sec = 0;
           
        Random rnd = new Random();
        



        //产生输入和结果数据
        private void createExp()
        {
            int operation= 0;
            int numRange = 0;
            if(radbtn10.Checked)
            {
                numRange = 9;
            }
            else if(radbtn20.Checked)
            {
                numRange = 19;
            }
            else if(radbtn100.Checked)
            {
                numRange = 99;
            }

            a = rnd.Next(numRange) + 1;
            b = rnd.Next(numRange) + 1;

            if(a<b)
            {
                int temp;
                temp = a;
                a = b;
                b = temp;
            }

            if (radbtnAdd.Checked)
            {
                operation = 0;
            }
            else if (radbtnMinus.Checked)
            {
                operation = 1;
            }
            else if (radbtnMul.Checked)
            {
                operation = 2;
                while (a * b >=1000)
                {
                    a = rnd.Next(numRange) + 1;
                    b = rnd.Next(numRange) + 1;

                    if (a < b)
                    {
                        int temp;
                        temp = a;
                        a = b;
                        b = temp;
                    }

                }
            }
            else if (radbtnDiv.Checked)
            {
                operation = 3;
                while(a%b!=0)
                {
                    a = rnd.Next(numRange) + 1;
                    b = rnd.Next(numRange) + 1;

                    if (a < b)
                    {
                        int temp;
                        temp = a;
                        a = b;
                        b = temp;
                    }

                }
            }

            switch (operation)
            {
                case 0: op = "+"; result = a + b; break;
                case 1: op = "-"; result = a - b; break;
                case 2: op = "*"; result = a * b; break;
                case 3: op = "/"; result = a / b; break;
            }


        }

        //自动计算
        private void timer1_Tick(object sender, EventArgs e)
        {
            sec = timer1.Interval/1000;

                if (chkDispNext.Checked && chkDispAnswer.Checked)
            {
                //  System.Threading.Thread.Sleep(1000);
                createExp();
                showExp();
                str = result.ToString();
                showResult();
            }
            else if (chkDispNext.Checked)
            {
                createExp();
                showExp();

            }
            if(chkDispAnswer.Checked)
            {

                str = result.ToString();
                showResult();
            }


        }

        //下一题
        private void btnNext_Click(object sender, EventArgs e)
        {



                createExp();
                showExp();
           //     showResult();


        }

        private void radbtnAdd_Click(object sender, EventArgs e)
        {

        }

        private void chkDispAnswer_Click(object sender, EventArgs e)
        {
            //if(chkDispAnswer.Checked==true)
            //{
            //    timer1.Enabled = true;
            //    timer2.Enabled = true;
            //}
            //else
            //{
            //    timer1.Enabled = false;
            //    timer2.Enabled = false;
            //}

        }

        private void txtAnswer_Click(object sender, EventArgs e)
        {
            txtAnswer.Clear();
 
        }

        private void txtAnswer_TextChanged(object sender, EventArgs e)
        {
            txtAnswer.ForeColor = Color.Black;
            txtInput = txtAnswer.Text;


        }

        //确认结果
        private void btnConfirm_Click(object sender, EventArgs e)
        {





            
            //if (chkDispNext.Checked)
            //{
            //    createExp();
            //    showExp();

            //}
            if(!keyFirst)
            {
                str = keyinput.ToString();
                keyFirst = true;
            }
            else
            {
                str = txtInput;
            }

            showResult();

        }

        //显示表达式 2+3= 和设定自动显示
        private void showExp()
        {
            txtAnswer.ForeColor = Color.Black;


            txtAnswer.Clear();

            lblA.Text = a.ToString();
            lblB.Text = b.ToString();
            lblOp.Text = op;

            //if (chkDispAnswer.Checked)
            //{
            //    str = result.ToString();

            //}
            //else
            //{
            //    str = "?";

            //}

            //if (chkDispNext.Checked)
            //{
            //    str = txtInput;
            //}
            //if(!keyFirst)
            //{
            //    str = keyinput.ToString();
            //}





        }

        //显示结果 3
        private void showResult()
        {
            int d;
            txtAnswer.Text = str;

            if (int.TryParse(str, out d))
            {

                disp = "" + a + op + b + "=" + str + " ";

                if (d == result)
                {
                    disp += " ☆";
                    txtAnswer.ForeColor = Color.Green;
                }
                else
                {
                    disp += "  x :try again!";
                    // disp += " ";
                    // disp += result;
                    txtAnswer.ForeColor = Color.Red;
                }


            }
            else
            {
                if (str == "")
                {
                    disp = "timeout";
                }
                else if (str == "?")
                {
                    disp = "please input";
                }
                else
                {
                    disp = "invalid input";
                }

            }

            lstDisp.Items.Add(disp);
            keyinput = 0;

        }


//计算速度调节
private void btnFast_Click(object sender, EventArgs e)
        {
            if(timer1.Interval>1000)
            {
                timer1.Interval -= 1000;
            }

            sec = timer1.Interval / 1000;
        }

        private void btnSlow_Click(object sender, EventArgs e)
        {
            timer1.Interval += 1000;
            sec = timer1.Interval / 1000;
        }


        //数字键盘
        private void btnNum1_Click(object sender, EventArgs e)
        {
            if(keyFirst)
            {
                keyinput = 0;
                keyFirst = false;
            }
            keyinput = keyinput * 10 + 1;
            txtAnswer.Text = keyinput.ToString();
        }

        private void btnNum0_Click(object sender, EventArgs e)
        {
            if (keyFirst)
            {
                keyinput = 0;
                keyFirst = false;
            }
            keyinput = keyinput * 10 + 0;
            txtAnswer.Text = keyinput.ToString();
        }

        private void btnNum2_Click(object sender, EventArgs e)
        {
            if (keyFirst)
            {
                keyinput = 0;
                keyFirst = false;
            }
            keyinput = keyinput * 10 + 2;
            txtAnswer.Text = keyinput.ToString();
        }

        private void btnNum3_Click(object sender, EventArgs e)
        {
            if (keyFirst)
            {
                keyinput = 0;
                keyFirst = false;
            }
            keyinput = keyinput * 10 + 3;
            txtAnswer.Text = keyinput.ToString();
        }

        private void btnNum4_Click(object sender, EventArgs e)
        {
            if (keyFirst)
            {
                keyinput = 0;
                keyFirst = false;
            }
            keyinput = keyinput * 10 + 4;
            txtAnswer.Text = keyinput.ToString();
        }

        private void btnNum5_Click(object sender, EventArgs e)
        {
            if (keyFirst)
            {
                keyinput = 0;
                keyFirst = false;
            }
            keyinput = keyinput * 10 + 5;
            txtAnswer.Text = keyinput.ToString();
        }

        private void btnNum6_Click(object sender, EventArgs e)
        {
            if (keyFirst)
            {
                keyinput = 0;
                keyFirst = false;
            }
            keyinput = keyinput * 10 + 6;
            txtAnswer.Text = keyinput.ToString();
        }

        private void btnNum7_Click(object sender, EventArgs e)
        {
            if (keyFirst)
            {
                keyinput = 0;
                keyFirst = false;
            }
            keyinput = keyinput * 10 + 7;
            txtAnswer.Text = keyinput.ToString();
        }

        private void btnNum8_Click(object sender, EventArgs e)
        {
            if (keyFirst)
            {
                keyinput = 0;
                keyFirst = false;
            }
            keyinput = keyinput * 10 + 8;
            txtAnswer.Text = keyinput.ToString();
        }

        private void btnNum9_Click(object sender, EventArgs e)
        {
            if (keyFirst)
            {
                keyinput = 0;
                keyFirst = false;
            }
            keyinput = keyinput * 10 + 9;
            txtAnswer.Text = keyinput.ToString();
        }

        private void lblSecShow_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if(sec>0)
            {
                sec--;
            }

            //lblSecShow.Text = "剩余" + sec.ToString() + "秒";
            lblSecShow.Text = "remain " + sec.ToString() + " sec";
        }

        private void chkDispNext_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDispNext.Checked == true)
            {
                timer1.Enabled = true;
                timer2.Enabled = true;
                sec = timer1.Interval / 1000;
                lblSecShow.Visible = true;

            }
            else if (chkDispNext.Checked == false || chkDispAnswer.Checked == false)
            {
                timer1.Enabled = false;
                timer2.Enabled = false;
                lblSecShow.Visible = false;
            }
        }

        private void chkDispAnswer_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDispAnswer.Checked == true)
            {
                timer1.Enabled = true;
                timer2.Enabled = true;
                sec = timer1.Interval / 1000;
                lblSecShow.Visible = true;

            }
            else if (!(chkDispNext.Checked==false || chkDispAnswer.Checked==false))
            {
                timer1.Enabled = false;
                timer2.Enabled = false;
                lblSecShow.Visible = false;
            }
        }

        private void btnKeyReset_Click(object sender, EventArgs e)
        {
            keyinput = 0;
            txtAnswer.Text = keyinput.ToString();
        }


    }
}