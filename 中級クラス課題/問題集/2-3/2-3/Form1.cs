using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2_3
{
    public partial class _2_3_Form : Form
    {
        private string[] who = { "佐藤", "鈴木", "高橋", "田中", "伊藤", "渡辺", "山本", "中村", "小林", "加藤" };
        private string[] what = { "卵", "ご飯", "ぱん", "鶏肉", "秋刀魚", "鰻", "白菜", "豚バラ", "ピーマン", "麺" };
        private string[] doing = { "食べる", "切る", "ゆでる", "炒める", "焼く", "蒸す", "割る", "買う", "腐らせる", "捨てる" };
        public _2_3_Form()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            Random rand = new Random();

            string output = this.who[rand.Next(11)] + "は" + this.what[rand.Next(11)] + "を" + this.doing[rand.Next(11)];

            MessageBox.Show(output);
        }
    }
}
