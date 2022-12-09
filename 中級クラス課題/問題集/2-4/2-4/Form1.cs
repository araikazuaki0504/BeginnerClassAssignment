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

namespace _2_4
{
    public partial class Form1 : Form
    {
        private List<string> sarcedLot = new List<string>();
        private string filePath = @"D:\Text\Test.txt";

        public Form1()
        {
            InitializeComponent();
            readDate();
        }

        private void readDate()
        {
            StreamReader SR = new StreamReader(filePath, Encoding.UTF8);

            while (-1 < SR.Peek())
            {
                this.sarcedLot.Add(SR.ReadLine());
            }

            SR.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Random Rand = new Random();
            int index = Rand.Next(12);

            MessageBox.Show(this.textBox1.Text + "さんの今日の運勢は..." + Environment.NewLine + sarcedLot[index]);
        }
    }
}
