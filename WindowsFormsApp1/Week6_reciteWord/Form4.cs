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
    public partial class Form4 : Form
    {
        Word[] testWord;
        string rightAnswer;
        string answer;
        public static int remember = 0;
        bool autoCheck=true;
        public Form4()
        {
            InitializeComponent();
        }



        private void rdoChoice4_CheckedChanged(object sender, EventArgs e)
        {

        }

        void generateQuestion()
        {
            int index = 0;
            int len = Form2.library.wordlist.Count();
            Random ran = new Random();

            foreach (Word test in testWord)
            {
               

                int id = ran.Next(1, len);
                
                string test_id = Form2.library.wordlist[id]._id;
                string test_english=Form2.library.wordlist[id]._english;
                string test_chinese = Form2.library.wordlist[id]._chinese;
                string test_phonenic = Form2.library.wordlist[id]._phonetic;
                testWord[index] = new Word(test_id, test_english, test_chinese, test_phonenic);
                index++;
            }

            lblQuestion.Text = testWord[0]._english;
            rightAnswer = testWord[0]._chinese;
            int temp= ran.Next(0, 3);

            rdoChoice1.Text = testWord[temp]._chinese;
            if(temp==1)
            {
                rdoChoice2.Text = testWord[0]._chinese;
            }
            else
            {
                rdoChoice2.Text = testWord[1]._chinese;
            }
            
            if(temp==2)
            {
                rdoChoice3.Text = testWord[0]._chinese;
            }
            else
            {
                rdoChoice3.Text = testWord[2]._chinese;
            }
           
            if(temp==3)
            {
                rdoChoice4.Text = testWord[0]._chinese;
            }
            else
            {
                rdoChoice4.Text = testWord[3]._chinese;
            }           

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            testWord = new Word[4];
            generateQuestion();

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            generateQuestion();
            lblResult.ForeColor = Color.Gray;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            checkResult();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void checkResult()
        {
            if (rdoChoice1.Checked == true)
            {
                answer = rdoChoice1.Text;
            }
            else if (rdoChoice2.Checked == true)
            {

                answer = rdoChoice2.Text;

            }
            else if (rdoChoice3.Checked == true)
            {

                answer = rdoChoice3.Text;

            }
            else if (rdoChoice4.Checked == true)
            {

                answer = rdoChoice4.Text;

            }

            if (answer == rightAnswer)
            {
                lblResult.Text = "correct";
                lblResult.ForeColor = Color.Green;
                remember++;
            }
            else
            {
                lblResult.Text = "wrong";
                lblResult.ForeColor = Color.Red;
            }
        }

     

    }
}
