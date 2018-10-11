using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Win
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        olconn g_conn = new olconn();
        string id="0";
        string Title = "";
        string Priority = "";
        string Status = "";
        string DueDate = "";
        string newid = "";
        string Key = "";


        private void Form1_Load(object sender, EventArgs e)
        {
            up();
        }

        private void up()
        {
            string cmdtxt = "select * from Tasks";
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = g_conn.ExecuteDataSet(cmdtxt).Tables[0];
            dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Ascending);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string cmdtxt = "insert into Tasks(ID,Title,Priority,Status,DueDate) values('" + newid + "','" + Title+"','"+Priority+"','"+Status+ "','" + DueDate + "')";
            id = newid;
            g_conn.GetExecute(cmdtxt);
            up();
            
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            string cmdtxt = "delete from Tasks where KEY="+Key;
            g_conn.GetExecute(cmdtxt);
            up();
        }

        private void btnUpd_Click(object sender, EventArgs e)
        {

          
            string cmdtxt = "update Tasks set ID='" + newid + "',Title ='" + Title + "',Priority='"+ Priority + "',Status='" + Status + "',DueDate='" + DueDate + "' where KEY=" + Key;
            id = newid;
            g_conn.GetExecute(cmdtxt);
            up();
        }

        private void btnSch_Click(object sender, EventArgs e)
        {
            string cmdtxt = "select * from Tasks where Title='study C#'";
            OleDbDataReader re = g_conn.Getreeader(cmdtxt);
            if (re.Read())
            {
                txtId.Text = re["Title"].ToString();
            }
            re.Close();
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            string rowIndex = e.RowIndex.ToString();
            //string id;
            //txtId.Text = rowIndex;
            id=dataGridView1.Rows[int.Parse(rowIndex)].Cells[0].Value.ToString();
            txtId.Text = id;
            Title= dataGridView1.Rows[int.Parse(rowIndex)].Cells[1].Value.ToString();
            txtTitle.Text = Title;
            Priority= dataGridView1.Rows[int.Parse(rowIndex)].Cells[2].Value.ToString();
            txtPriority.Text = Priority;
            Status= dataGridView1.Rows[int.Parse(rowIndex)].Cells[3].Value.ToString();
            txtStatus.Text = Status;
            cmbPriority.Text = Priority;
            cmbStatus.Text = Status;
            DueDate= dataGridView1.Rows[int.Parse(rowIndex)].Cells[4].Value.ToString();
            dateTimePicker1.Text = DueDate;
            Key= dataGridView1.Rows[int.Parse(rowIndex)].Cells[5].Value.ToString();

        }

        private void txtTitle_TextChanged(object sender, EventArgs e)
        {
            string tmp;
            tmp = txtTitle.Text;
            if (tmp.Length>0)
            {
                Title = tmp;
            }
        }

        private void txtPriority_TextChanged(object sender, EventArgs e)
        {
            string tmp;
            tmp = txtPriority.Text;
            if (tmp.Length > 0)
            {
                Priority = tmp;
            }
        }

        private void txtStatus_TextChanged(object sender, EventArgs e)
        {
            string tmp;
            tmp = txtStatus.Text;
            if (tmp.Length > 0)
            {
                Status = tmp;
            }
        }

        private void cmbPriority_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tmp;
            tmp = cmbPriority.Text;
            if (tmp.Length > 0)
            {
                Priority = tmp;
            }
        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tmp;
            tmp = cmbStatus.Text;
            if (tmp.Length > 0)
            {
                Status = tmp;
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            string tmp;
            tmp = dateTimePicker1.Text;
            if (tmp.Length > 0)
            {
                DueDate = tmp;
            }
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {
            string tmp;
            tmp = txtId.Text;
            if (tmp.Length > 0)
            {
                newid = tmp;
            }
        }
    }
}
