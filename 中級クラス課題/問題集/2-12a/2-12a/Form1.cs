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

namespace _2_12a
{
    public partial class _2_12a_Form : Form
    {
        private List<string[]> Data = new List<string[]>();
        public _2_12a_Form()
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
                string Address = ViewSetDate[6].Replace("\"","") + ViewSetDate[7].Replace("\"","") + ViewSetDate[8].Replace("\"","");
                string[] SetData = { ViewSetDate[2].Replace("\"", ""), Address };
                ListViewItem item = new ListViewItem(SetData);

                this.Address_listView.Items.Add(item);
            }
        }

        private void DataWriter(string FilePath)
        {
            StreamWriter Writer = new StreamWriter(FilePath, false, Encoding.UTF8);

            foreach (string[] WriteData in Data)
            {
                string Address = WriteData[6].Replace("\"", "") + WriteData[7].Replace("\"", "") + WriteData[8].Replace("\"", "");
                string WriteString = WriteData[2] + "," + "\"" + Address + "\"";
                Writer.WriteLine(WriteString);
            }

            Writer.Close();
        }
        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            this.DataWriter(this.saveFileDialog1.FileName);
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            this.DataReader(this.openFileDialog1.FileName);
            this.DataSet();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Address_listView.Items.Clear();
            this.openFileDialog1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.saveFileDialog1.ShowDialog();
        }
    }
}
