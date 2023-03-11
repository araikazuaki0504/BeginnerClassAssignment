using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 問題39
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            //インデックス0が大人料金、インデックス1が子供料金
            //渋谷、池袋、東京、上野、品川
            int[,] FareTable = { { 150, 150, 190, 190, 190 }, { 70, 70, 90, 90, 90 } };
            bool[] Is_CheckedFor = { this.radioButton_For_Shibuya.Checked, this.radioButton_For_Ikebukuro.Checked, this.radioButton_For_Tokyo.Checked, this.radioButton_For_Ueno.Checked, this.radioButton_For_Shinagawa.Checked };
            string Fare = string.Empty;

            //大人にcheckがついていれば 1, 子供にcheckがついていれば 0
            int ChildOrAdult = this.radioButton_adult.Checked ? 0 : 1 ;

            for (int index = 0; index < Is_CheckedFor.Length; index++)
            {
                if (Is_CheckedFor[index] == true)
                {
                    Fare = FareTable[ChildOrAdult, index].ToString();
                }
            }

            MessageBox.Show("運賃は" + Fare + "になります");
        }
    }
}
