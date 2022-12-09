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
    public partial class _2_5_Form : Form
    {
        public _2_5_Form()
        {
            InitializeComponent();
        }

        private void display_Click(object sender, EventArgs e)
        {
            string output = this.Name_textBox.Text + "さん、あなたの誕生日は" + this.Month_textBox.Text + "月" + this.Day_textBox.Text + "日ですね。";
            MessageBox.Show(output);
        }
    }
}
