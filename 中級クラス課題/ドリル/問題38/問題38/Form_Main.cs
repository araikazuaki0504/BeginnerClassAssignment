using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 問題38
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        private void radioButton_Male_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButton_Male.Checked == true)
            {
                this.textBox_male.ReadOnly = false;
            }
            else
            {
                this.textBox_male.ReadOnly = true;
            }
        }

        private void radioButton_female_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButton_female.Checked == true)
            {
                this.textBox_female.ReadOnly = false;
            }
            else
            {
                this.textBox_female.ReadOnly = true;
            }
        }
    }
}
