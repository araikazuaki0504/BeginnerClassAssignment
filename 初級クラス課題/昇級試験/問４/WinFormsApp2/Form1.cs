using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Sum_Click(object sender, EventArgs e)
        {
            int total = 0;
            int num = 0;

            for(int i = 0; i < this.listBox1.Items.Count; i++)
            {
                num = int.Parse(this.listBox1.Items[i].ToString());

                if (21 <= num)
                {
                    total += num;
                }
            }

            MessageBox.Show("合計 ＝ " + total.ToString(),"",MessageBoxButtons.OK);
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
