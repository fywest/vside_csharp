using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BackgroundWorkerSimple
{
    public partial class Form1 : Form
    {
        private int percentValue = 0;

        //form2
        private Form2 notifyForm = new Form2();

        public Form1()
        {
            InitializeComponent();

            //form2
            CheckForIllegalCrossThreadCalls = false;
        }

        private void startAsyncButton_Click(object sender, EventArgs e)
        {
            if(backgroundWorker1.IsBusy !=true)
            {
                percentValue = 10;
                this.progressBar1.Maximum = 100;
                backgroundWorker1.RunWorkerAsync();

                //form2
                //notifyForm.StartPosition = FormStartPosition.CenterParent;
                //notifyForm.ShowDialog();

            }
        }

        private void canelAsyncButton_Click(object sender, EventArgs e)
        {
            if(backgroundWorker1.WorkerSupportsCancellation==true)
            {
                backgroundWorker1.CancelAsync();
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            for (int i = 1; i <= 10; i++)
            {
                if (worker.CancellationPending == true)
                {
                    e.Cancel = true;
                    break;
                }
                else
                {
                    System.Threading.Thread.Sleep(500);
                    worker.ReportProgress(i * 10);
                }
            }

        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            resultLabel.Text = (e.ProgressPercentage.ToString() + "%");
            this.progressBar1.Value = e.ProgressPercentage;

            //form2
            //notifyForm.SetNotifyInfo(e.ProgressPercentage, "progress:" + Convert.ToString(e.ProgressPercentage) + "%");
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if(e.Cancelled==true)
            {
                resultLabel.Text = "Canceled!";
            }
            else if(e.Error!=null)
            {
                resultLabel.Text = "Error: " + e.Error.Message;
            }
            else
            {
                resultLabel.Text = "Done!";
            }

            //form2
            //notifyForm.Close();
            //MessageBox.Show("done and windows close");
            
        }

        private void startAsyncButton2_Click(object sender, EventArgs e)
        {
            if (notifyForm.backgroundWorker1.IsBusy != true)
            {

                notifyForm.reset_progressbar();
                notifyForm.backgroundWorker1.RunWorkerAsync();
                notifyForm.StartPosition = FormStartPosition.CenterParent;
                notifyForm.ShowDialog();
            }
     
        }

        private void canelAsyncButton2_Click(object sender, EventArgs e)
        {

            MessageBox.Show("close");
        }
    }
}
