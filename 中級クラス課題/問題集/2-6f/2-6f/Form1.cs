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

namespace _2_6f
{
    public partial class Form1 : Form
    {
        private string filePath = @"D:\Text\results.txt";
        private List<string[]> buff = new List<string[]>();
        public Form1()
        {
            InitializeComponent();
            DateReader();
            ComboBoxSetting();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.comboBox2.SelectedItem == null)
            {

            }
            else if (this.comboBox2.SelectedItem.ToString() == "全員")
            {
                this.listView1.Items.Clear();
                foreach (string[] Date in buff)
                {
                    ListViewItem tmpDate = setDate(Date);

                    this.listView1.Items.Add(tmpDate);
                }
            }
            else
            {
                this.listView1.Items.Clear();

                foreach (string[] Date in buff)
                {
                    if (this.comboBox2.SelectedItem.ToString() == Date[0])
                    {
                        ListViewItem tmpDate = setDate(Date);

                        this.listView1.Items.Add(tmpDate);
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

        private ListViewItem setDate(string[] inputDate)
        {
            int index = 0;

            switch (this.comboBox1.SelectedItem)
            {
                case "国語":
                    index = 1;
                    break;
                case "数学":
                    index = 2;
                    break;
                case "英語":
                    index = 3;
                    break;
            }

            string[] tmpViewItem = { inputDate[0], inputDate[index] };
            ListViewItem ReturnViewItem = new ListViewItem(tmpViewItem);

            return ReturnViewItem;
        }

        private void ComboBoxSetting()
        {
            foreach (string[] combo in buff)
            {
                this.comboBox2.Items.Add(combo[0]);
            }

            this.comboBox2.Items.Add("全員");

            this.comboBox1.SelectedItem = "国語";
            this.comboBox2.SelectedItem = "全員";
        }
    }
}
