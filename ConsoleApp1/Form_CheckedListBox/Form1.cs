using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_CheckedListBox
{
    using System;
    using System.Drawing;
    using System.Collections;
    using System.ComponentModel;
    using System.Windows.Forms;
    using System.Data;
    using System.IO;

    public partial class Form1 : Form
    {

        private CheckedListBox checkedListBox1;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private ListBox listBox1;
        private Button button3;

        public Form1()
        {
            InitializeComponent();

            // Sets up the initial objects in the CheckedListBox.
            string[] myFruit = { "Apples", "Oranges", "Tomato" };
            checkedListBox1.Items.AddRange(myFruit);

            // Changes the selection mode from double-click to single click.
            checkedListBox1.CheckOnClick = true;
        }

        // Adds the string if the text box has data in it.
        private void button1_Click(object sender, System.EventArgs e)
        {
            if (textBox1.Text != "")
            {
                if (checkedListBox1.CheckedItems.Contains(textBox1.Text) == false)
                    checkedListBox1.Items.Add(textBox1.Text, CheckState.Checked);
                textBox1.Text = "";
            }

        }
        // Activates or deactivates the Add button.
        private void textBox1_TextChanged(object sender, System.EventArgs e)
        {
            if (textBox1.Text == "")
            {
                button1.Enabled = false;
            }
            else
            {
                button1.Enabled = true;
            }

        }

        // Moves the checked items from the CheckedListBox to the listBox.
        private void button2_Click(object sender, System.EventArgs e)
        {
            listBox1.Items.Clear();
            button3.Enabled = false;
            for (int i = 0; i < checkedListBox1.CheckedItems.Count; i++)
            {
                listBox1.Items.Add(checkedListBox1.CheckedItems[i]);
            }
            if (listBox1.Items.Count > 0)
                button3.Enabled = true;

        }
        // Activates the move button if there are checked items.
        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Unchecked)
            {
                if (checkedListBox1.CheckedItems.Count == 1)
                {
                    button2.Enabled = false;
                }
            }
            else
            {
                button2.Enabled = true;
            }
        }

        // Saves the items to a file.
        private void button3_Click(object sender, System.EventArgs e)
        {
            // Insert code to save a file.
            listBox1.Items.Clear();
            IEnumerator myEnumerator;
            myEnumerator = checkedListBox1.CheckedIndices.GetEnumerator();
            int y;
            while (myEnumerator.MoveNext() != false)
            {
                y = (int)myEnumerator.Current;
                checkedListBox1.SetItemChecked(y, false);
            }
            button3.Enabled = false;
        }
    }
}
