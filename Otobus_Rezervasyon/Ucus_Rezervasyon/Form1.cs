﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ucus_Rezervasyon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Sefer Bilgileri : " +comboBox1.Text + " - " + comboBox2.Text + " - " + dateTimePicker1.Text + " - " + maskedTextBox1.Text);
            listBox1.Items.Add("\n");
            listBox1.Items.Add("Yolcu Bilgileri : " +textBox1.Text + " - " + maskedTextBox2.Text + " - " + maskedTextBox3.Text);
        }
    }
}
