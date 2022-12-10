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

namespace _3_6
{
    public partial class _3_7_Form : Form
    {
        private List<string[]> Data = new List<string[]>();

        public _3_7_Form()
        {
            InitializeComponent();
        }

        private void Read_button_Click(object sender, EventArgs e)
        {
            this.File_Read_Dialog.ShowDialog();
        }

        private void Write_button_Click(object sender, EventArgs e)
        {
            this.File_Write_Dialog.ShowDialog();
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

                this.Display_listView.Items.Add(item);
            }
        }

        private void DataWriter(string FilePath)
        {
            StreamWriter Writer = new StreamWriter(FilePath, false, Encoding.UTF8);

            for (int i = 0; i < this.Display_listView.SelectedItems.Count; i++)
            {
                int WriterIndex = this.Display_listView.SelectedIndices[i];
                string[] WriteData = this.Data[WriterIndex];
                string Address = WriteData[6].Replace("\"", "") + WriteData[7].Replace("\"", "") + WriteData[8].Replace("\"", "");
                string WriteString = WriteData[2] + "," + "\"" + Address + "\"";
                Writer.WriteLine(WriteString);
            }

            Writer.Close();
        }

        private void File_Read_Dialog_FileOk(object sender, CancelEventArgs e)
        {
            this.DataReader(this.File_Read_Dialog.FileName);
            this.DataSet();
        }

        private void File_Write_Dialog_FileOk(object sender, CancelEventArgs e)
        {
            if (this.Display_listView.SelectedItems.Count == 0)
            {
                MessageBox.Show("保存する住所を選択してください");
            }
            else
            {
                this.DataWriter(this.File_Write_Dialog.FileName);
            }

        }
    }
}
