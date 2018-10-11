using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace reciteWord1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }


        

        private void Form1_Load(object sender, EventArgs e)
        {
           // WordLibrary library = new WordLibrary("College_Grade4");
            //Form2.library.ReadFile();
            //ShowWord(library);
            UpdateDisplayWord(Form2.library);
        }

        void ShowWord(WordLibrary library)
        {
            string msg="";
            foreach (Word w in library.wordlist)
            {

                msg+= w._english + "\t" + w._chinese + "\t" + w._phonetic + "\n";
                
            }
            MessageBox.Show(msg);


        }

        private void UpdateDisplayWord(WordLibrary library)
        {
            library.ReadFile();
            listView1.Items.Clear();
            listView1.Columns.Add("Id", 50, HorizontalAlignment.Left); //一步添加
            listView1.Columns.Add("English", 120, HorizontalAlignment.Left); //一步添加
            listView1.Columns.Add("Chinese", 180, HorizontalAlignment.Left); //一步添加
            listView1.Columns.Add("Phonetic", 100, HorizontalAlignment.Left); //一步添加
            listView1.Columns.Add("Status", 50, HorizontalAlignment.Left); //一步添加
            foreach (Word w in library.wordlist)
            {
                ListViewItem lvi = new ListViewItem();


                lvi.Text = w._id.ToString();
                listView1.Items.Add(lvi);

                ListViewItem.ListViewSubItem lvsi = new ListViewItem.ListViewSubItem();
                lvsi.Text = w._english;
                lvi.SubItems.Add(lvsi);

                lvsi = new ListViewItem.ListViewSubItem();
                lvsi.Text = w._chinese;
                lvi.SubItems.Add(lvsi);

                lvsi = new ListViewItem.ListViewSubItem();
                lvsi.Text = w._phonetic;
                lvsi.Font = new Font("Kingsoft Phonetic Plain", 9);
                lvi.SubItems.Add(lvsi);

                lvsi = new ListViewItem.ListViewSubItem();
                lvsi.Text = w._status.ToString();
                lvi.SubItems.Add(lvsi);
            }
        }
    }



}
