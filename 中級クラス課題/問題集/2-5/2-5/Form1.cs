using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void display_Click(object sender, EventArgs e)
        {
            string output = this.textBox1.Text + "さん、あなたの誕生日は" + this.textBox2.Text + "月" + this.textBox3.Text + "日ですね。";
            MessageBox.Show(output);
        }
    }
}
