using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 問題46
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        private void SizeUpButton_Click(object sender, EventArgs e)
        {
            Size dSize = new Size(10, 10);
            this.SizeUpButton.Size += dSize;
        }
    }
}
