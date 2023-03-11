using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 問題44
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        private void ToRightArrow_Click(object sender, EventArgs e)
        {
            try
            {
                this.listBox_view.Items.Add(this.comboBox_City.SelectedItem);
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("選んでください");
            }
        }

        private void ToLeftArrow_Click(object sender, EventArgs e)
        {
            try
            {
                this.listBox_view.Items.RemoveAt(this.listBox_view.SelectedIndex);
            }catch(ArgumentOutOfRangeException)
            {
                MessageBox.Show("選んでください");
            }
        }
    }
}
