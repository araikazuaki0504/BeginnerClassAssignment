﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2_9
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TimeSpan span = DateTime.Today - this.BrithDay_dateTimePicker.Value;
            MessageBox.Show("あなたが生まれてから" + span.Days.ToString() + "日目です。");
        }
    }
}
