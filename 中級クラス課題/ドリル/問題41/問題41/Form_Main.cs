using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 問題41
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        private void buttonToAdd_Click(object sender, EventArgs e)
        {
            this.DisplayComboBox.Items.Add(this.textBoxToAddOrRemove.Text);
        }

        private void buttonToRemove_Click(object sender, EventArgs e)
        {
            int TargetIndex = this.DisplayComboBox.Items.IndexOf(this.textBoxToAddOrRemove.Text);

            this.DisplayComboBox.Items.RemoveAt(TargetIndex);
        }
    }
}
