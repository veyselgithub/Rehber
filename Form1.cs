﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rehber
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
            
        }

        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
