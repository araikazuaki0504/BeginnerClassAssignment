using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2_7
{
    public partial class Form1 : Form
    {
        private int Ans = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random Rand = new Random();

            this.Ans = Rand.Next(100);

            this.button1.Enabled = false;
            this.button2.Enabled = true;
            this.textBox1.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.Ans == int.Parse(this.textBox1.Text))
            {
                MessageBox.Show("正解です。おめでとう！");
                this.button1.Enabled = true;
                this.button2.Enabled = false;
                this.textBox1.Enabled = false;
                this.textBox1.Text = string.Empty;
            }
            else if (this.Ans < int.Parse(this.textBox1.Text))
            {
                MessageBox.Show("もっと小さいです。");
                this.textBox1.Text = string.Empty;
            }
            else if (this.Ans > int.Parse(this.textBox1.Text))
            {
                MessageBox.Show("もっと大きいです。");
                this.textBox1.Text = string.Empty;
            }
        }
    }
}
