using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2_11b
{
    public partial class Form_Main : Form
    {
        private DateTime timer = DateTime.Parse("00:00");

        public Form_Main()
        {
            InitializeComponent();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            this.timer = this.timer.AddSeconds(1.0);
            this.Time_label.Text = this.timer.ToString("mm:ss");
            
        }

        private void StartButton(object sender, EventArgs e)
        {
            this.timer1.Enabled = true;
            this.Lap_button.Enabled = true;
        }

        private void Stop_Button(object sender, EventArgs e)
        {
            this.timer1.Enabled = false;
        }

        private void Lap_Button(object sender, EventArgs e)
        {
            this.LapTime_listBox.Items.Add(timer.ToString("mm:ss"));
        }

        private void ResetButton(object sender, EventArgs e)
        {
            this.timer1.Enabled = false;
            this.Time_label.Text = "00:00";
            this.LapTime_listBox.Items.Clear();
        }
    }
}
