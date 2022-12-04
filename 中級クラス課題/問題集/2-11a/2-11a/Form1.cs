using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2_11a
{
    public partial class Form1 : Form
    {
        private DateTime timer = DateTime.Parse("00:00");
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.timer1.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.timer1.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.timer = this.timer.AddSeconds(1.0);
            
            if (this.label1.Text == "59:59")
            {
                this.label1.Text = "00:00";
            }
            else
            {
                this.label1.Text = this.timer.ToString("mm:ss");
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.timer1.Enabled = false;
            this.label1.Text = "00:00";
            this.timer = DateTime.Parse("00:00");
        }
    }
}
