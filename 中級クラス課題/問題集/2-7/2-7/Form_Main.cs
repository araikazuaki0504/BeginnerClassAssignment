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
    public partial class Form_Main : Form
    {
        private int Ans = 0;

        public Form_Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random Rand = new Random();

            this.Ans = Rand.Next(100);

            this.Start_button.Enabled = false;
            this.Check_button.Enabled = true;
            this.inputNum_textBox.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.Ans == int.Parse(this.inputNum_textBox.Text))
            {
                MessageBox.Show("正解です。おめでとう！");
                this.Start_button.Enabled = true;
                this.Check_button.Enabled = false;
                this.inputNum_textBox.Enabled = false;
                this.inputNum_textBox.Text = string.Empty;
            }
            else if (this.Ans < int.Parse(this.inputNum_textBox.Text))
            {
                MessageBox.Show("もっと小さいです。");
                this.inputNum_textBox.Text = string.Empty;
            }
            else if (this.Ans > int.Parse(this.inputNum_textBox.Text))
            {
                MessageBox.Show("もっと大きいです。");
                this.inputNum_textBox.Text = string.Empty;
            }
        }
    }
}
