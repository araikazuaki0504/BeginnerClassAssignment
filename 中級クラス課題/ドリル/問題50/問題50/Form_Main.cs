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

namespace 問題50
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            string FilePath = @"C:\Users\Public\Documents\name.txt";
            string[] Data = ReadDataFromTextFile(FilePath);

            MessageBox.Show($"{Data[0]}\n{Data[1]}");
        }

        private string[] ReadDataFromTextFile(string FilePath)
        {
            string GetData = string.Empty;

            StreamReader Reader = new StreamReader(FilePath, Encoding.UTF8);

            while (Reader.Peek() > -1)
            {
                GetData += Reader.ReadLine() + ",";
            }

            Reader.Close();

            return GetData.Split(",");
        }
    }
}
