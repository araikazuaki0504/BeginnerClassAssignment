using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    { 
        public Form1()
        {
            InitializeComponent();
        }

        private void plus_Click(object sender, EventArgs e)
        {
            int sum = int.Parse(this.Sum.Text);
            sum += int.Parse(this.Price.Text);

            this.Sum.Text = sum.ToString();

            sum = (int)(1.08 * sum);

            this.Tax_price.Text = sum.ToString();
        }

        private void init_Click(object sender, EventArgs e)
        {
            this.Sum.Text = (0).ToString();
            this.Tax_price.Text = (0).ToString();
            this.Price.Text = (0).ToString();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
