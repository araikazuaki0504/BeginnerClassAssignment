﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;
using System.IO;

namespace _2_6c
{
    public partial class Form1 : Form
    {
        private string filePath = @"D:\Text\results.txt";
        private List<string[]> buff = new List<string[]>();

        public Form1()
        {
            InitializeComponent();
            DateReader();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.listView1.Items.Clear();
            this.listView2.Items.Clear();
            this.listView3.Items.Clear();

            foreach (string[] Date in buff)
            {
                List<ListViewItem> tmpDate = setDate(Date);
                this.listView1.Items.Add(tmpDate[0]);
                this.listView2.Items.Add(tmpDate[1]);
                this.listView3.Items.Add(tmpDate[2]);
                
            }
        }

        private void DateReader()
        {
            StreamReader SR = new StreamReader(filePath, Encoding.UTF8);
            
            while (-1 < SR.Peek())
            {
                this.buff.Add(SR.ReadLine().Split(" "));
            }

            SR.Close();
        }

        private List<ListViewItem> setDate(string[] inputDate)
        {
            List<ListViewItem> ReturnVector = new List<ListViewItem>();

            for (int i = 1; i < 4; i++)
            {
                string[] Vector = { inputDate[0], inputDate[i] };
                ListViewItem listViewItem = new ListViewItem(Vector);
                ReturnVector.Add(listViewItem);
            }

            return ReturnVector;
        }
    }
}
