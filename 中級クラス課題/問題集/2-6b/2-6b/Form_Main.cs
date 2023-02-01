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
using System.Collections.Generic;

namespace _2_6b
{
    public partial class Form_Main : Form
    {
        private string filePath = @"D:\Text\results.txt";
        public Form_Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string[]> buff = new List<string[]>();
            StreamReader SR = new StreamReader(filePath, Encoding.UTF8);

            while (-1 < SR.Peek())
            {
                buff.Add(SR.ReadLine().Split(" "));
            }

            SR.Close();

            this.ListView.Items.Clear();

            foreach (string[] outPut in buff)
            {
                ListViewItem viewItem = new ListViewItem(outPut);
                this.ListView.Items.Add(viewItem);
            }
            
        }
        
    }
}
