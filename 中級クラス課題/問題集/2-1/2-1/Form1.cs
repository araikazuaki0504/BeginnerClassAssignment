using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2_1
{
    public partial class queLabel : Form
    {
        public queLabel()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            uint Age = uint.Parse(this.inputAge.Text);

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
    }
}
