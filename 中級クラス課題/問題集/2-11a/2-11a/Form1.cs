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
    public partial class _2_11a_Form : Form
    {
        private DateTime timer = DateTime.Parse("00:00");
        public _2_11a_Form()
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
            
            if (this.Time_label.Text == "59:59")
            {
                this.Time_label.Text = "00:00";
            }
            else
            {
                this.Time_label.Text = this.timer.ToString("mm:ss");
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.timer1.Enabled = false;
            this.Time_label.Text = "00:00";
            this.timer = DateTime.Parse("00:00");
        }
    }
}
