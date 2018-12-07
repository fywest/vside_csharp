using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BackgroundThread
{
    public partial class Form1 : Form
    {
        private Form2 progressForm = new Form2();
        private delegate void funHandle(int nValue);
        private funHandle myHandle = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            System.Threading.Thread thread = new System.Threading.Thread(new System.Threading.ThreadStart(ThreadFun));
            thread.Start();
        }

        private void ShowProgresbar()
        {
            myHandle = new funHandle(progressForm.SetProgressValue);

            progressForm.StartPosition = FormStartPosition.CenterParent;
            progressForm.ShowDialog();
        }

        private void ThreadFun()
        {
            MethodInvoker mi = new MethodInvoker(ShowProgresbar);
            this.BeginInvoke(mi);
            System.Threading.Thread.Sleep(1000);

            for (int i = 0; i < 1000; ++i)
            {
                System.Threading.Thread.Sleep(5);
                this.Invoke(this.myHandle, new object[] { i / 10 });
            }
        }

    }
}
