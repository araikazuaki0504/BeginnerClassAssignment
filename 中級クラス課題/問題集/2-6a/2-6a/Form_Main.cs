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


namespace _2_6a
{
    public partial class Form_Main : Form
    {
        private string filePath = @"D:\Text\names.txt";
        public Form_Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamReader SR = new StreamReader(filePath, Encoding.UTF8);
            List<string> buff = new List<string>();

            this.Name_listBox.Items.Clear();
 
            while (-1 < SR.Peek())
            {
                buff.Add(SR.ReadLine());
            }

            SR.Close();

           foreach (string output in buff)
            {
                this.Name_listBox.Items.Add(output);
            }
        }
    }
}
