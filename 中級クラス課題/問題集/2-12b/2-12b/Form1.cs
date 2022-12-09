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

namespace _2_12b
{
    public partial class _2_12b_Form : Form
    {
        private List<string[]> Data = new List<string[]>();

        public _2_12b_Form()
        {
            InitializeComponent();
        }

        private void DataReader(string FilePath)
        {
            StreamReader Reader = new StreamReader(FilePath, Encoding.UTF8);

            while (-1 < Reader.Peek())
            {
                this.Data.Add(Reader.ReadLine().ToString().Split(","));
            }

            Reader.Close();
        }

        private void DataSet()
        {
            foreach (string[] ViewSetDate in Data)
            {
                string Address = ViewSetDate[6].Replace("\"", "") + ViewSetDate[7].Replace("\"", "") + ViewSetDate[8].Replace("\"", "");
                string[] SetData = { ViewSetDate[2].Replace("\"", ""), Address };
                ListViewItem item = new ListViewItem(SetData);

                this.Address_listView.Items.Add(item);
            }
        }

        private void DataWriter(string FilePath)
        {
            StreamWriter Writer = new StreamWriter(FilePath, false, Encoding.UTF8);

            for (int i = 0; i < this.Address_listView.SelectedItems.Count; i++)
            {
                int WriterIndex = this.Address_listView.SelectedIndices[i];
                string[] WriteData = this.Data[WriterIndex];
                string Address = WriteData[6].Replace("\"", "") + WriteData[7].Replace("\"", "") + WriteData[8].Replace("\"", "");
                string WriteString = WriteData[2] + "," + "\"" + Address + "\"";
                Writer.WriteLine(WriteString);
            }

            Writer.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.saveFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            this.DataReader(this.openFileDialog1.FileName);
            this.DataSet();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            if (this.Address_listView.SelectedItems.Count == 0)
            {
                MessageBox.Show("保存する住所を選択してください");
            }
            else
            {
                this.DataWriter(this.saveFileDialog1.FileName);
            }
            
        }
    }
}
