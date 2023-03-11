using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 問題45
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        private void buttonToMove_Click(object sender, EventArgs e)
        {
            Point dPos = new Point(10, 10);

            this.MovingLabel.Location = Point_Add(this.MovingLabel.Location, dPos);
        }

        /// <summary>
        /// Point構造体の加算が出来なさそうなので、作った関数
        /// </summary>
        /// <param name="Pos_1"></param>
        /// <param name="Pos_2"></param>
        /// <returns></returns>
        Point Point_Add(Point Pos_1, Point Pos_2)
        {
            return new Point(Pos_1.X + Pos_2.X, Pos_1.Y + Pos_2.Y);
        }
    }
}
