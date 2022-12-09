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
    public partial class _2_6f_Form : Form
    {
        private string filePath = @"D:\Text\results.txt";
        private List<string[]> buff = new List<string[]>();
        public _2_6f_Form()
        {
            InitializeComponent();
            DateReader();
            ComboBoxSetting();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.Name_comboBox.SelectedItem == null)
            {

            }
            else if (this.Name_comboBox.SelectedItem.ToString() == "全員")
            {
                this.NameAndPoint_listView.Items.Clear();
                foreach (string[] Date in buff)
                {
                    ListViewItem tmpDate = setDate(Date);

                    this.NameAndPoint_listView.Items.Add(tmpDate);
                }
            }
            else
            {
                this.NameAndPoint_listView.Items.Clear();

                foreach (string[] Date in buff)
                {
                    if (this.Name_comboBox.SelectedItem.ToString() == Date[0])
                    {
                        ListViewItem tmpDate = setDate(Date);

                        this.NameAndPoint_listView.Items.Add(tmpDate);
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

            switch (this.Subject_comboBox.SelectedItem)
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
                this.Name_comboBox.Items.Add(combo[0]);
            }

            this.Name_comboBox.Items.Add("全員");

            this.Subject_comboBox.SelectedItem = "国語";
            this.Name_comboBox.SelectedItem = "全員";
        }
    }
}
