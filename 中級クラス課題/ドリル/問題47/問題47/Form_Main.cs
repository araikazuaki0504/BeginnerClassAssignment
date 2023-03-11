using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 問題47
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            string Color = "赤,青,黄色,緑,桃,黒,白";
            String[] SplitedColor = Color.Split(",");

            String OutputText = string.Empty;

            for (int index = 0; index < SplitedColor.Length; index++)
            {
                OutputText += $"{index + 1}番 {SplitedColor[index]}\n";
            }

            MessageBox.Show(OutputText);
        }
    }
}
