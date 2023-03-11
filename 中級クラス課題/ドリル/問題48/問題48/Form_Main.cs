using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 問題48
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            string colors = "赤,青,黄,緑,桃,黒,白";
            string[] SplitedColor = colors.Split(",");
            string OutPutText = string.Empty;
 
            for (int index = 0; index < SplitedColor.Length; index++)
            {
                SplitedColor[index] = $"{index + 1}番 {SplitedColor[index]}";
            }

            OutPutText = string.Join(",", SplitedColor);
            MessageBox.Show(OutPutText);
        }
    }
}
