﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace smartrac_sw
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Text = "read reader info";
            string msg;
            //HF_Reader hf_reader1=new HF_Reader("Smartrac","NTAG213",12.5);
            HF_FEIG hf_feig1 = new HF_FEIG("Smartrac", "NTAG213", 12.5);
            //MessageBox.Show(hf_feig1.WriteBlock());

            msg = hf_feig1.SelectCommand();

            MessageBox.Show(msg);


        }
    }
}