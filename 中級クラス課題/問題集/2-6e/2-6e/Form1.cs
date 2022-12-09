﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _2_6e
{
    public partial class _2_6e_Form : Form
    {
        private string filePath = @"D:\Text\results.txt";
        private List<string[]> buff = new List<string[]>();
        public _2_6e_Form()
        {
            InitializeComponent();
            DateReader();
            ComboBoxSetting();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.Chose_Name_Combo.SelectedItem == null)
            {
              
            }
            else if (this.Chose_Name_Combo.SelectedItem.ToString() == "全員")
            {
                this.Jap_listView.Items.Clear();
                this.Math_listView.Items.Clear();
                this.Eng_listView.Items.Clear();
                foreach (string[] Date in buff)
                {
                    List<ListViewItem> tmpDate = setDate(Date);

                    this.Jap_listView.Items.Add(tmpDate[0]);
                    this.Math_listView.Items.Add(tmpDate[1]);
                    this.Eng_listView.Items.Add(tmpDate[2]);
                }
            }
            else
            {
                this.Jap_listView.Items.Clear();
                this.Math_listView.Items.Clear();
                this.Eng_listView.Items.Clear();

                foreach (string[] Date in buff)
                {
                    if (this.Chose_Name_Combo.SelectedItem.ToString() == Date[0])
                    {
                        List<ListViewItem> tmpDate = setDate(Date);

                        this.Jap_listView.Items.Add(tmpDate[0]);
                        this.Math_listView.Items.Add(tmpDate[1]);
                        this.Eng_listView.Items.Add(tmpDate[2]);
                    }
                }
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

        private void ComboBoxSetting()
        {
            foreach (string[] combo in buff)
            {
                this.Chose_Name_Combo.Items.Add(combo[0]);
            }

            this.Chose_Name_Combo.Items.Add("全員");
        }
    }
}
