using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5_2
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        private void OK_button_Click(object sender, EventArgs e)
        {
            uint Age = 0;

            if (uint.TryParse(this.inputAge.Text, out Age))
            {
                if (16 > Age)
                {
                    MessageBox.Show("原付の免許も自動車の免許も取得できません。");
                }
                else if (16 <= Age && Age < 18)
                {
                    MessageBox.Show("原付の免許を取得できますが、自動車の免許は取得できません.");
                }
                else if (Age >= 18)
                {
                    MessageBox.Show("原付の免許も自動車の免許も取得できます。");
                }
            }
            else
            {
                MessageBox.Show("年齢を入力してください。");
                this.inputAge.Text = "";
            }
        }
        
    }
}
