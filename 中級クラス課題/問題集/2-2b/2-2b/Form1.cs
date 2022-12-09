using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2_2b
{
    public partial class _2_2b_Form : Form
    {
        private string[] sarcedLot = {
            "大吉：今日は最高の一日",
            "吉：いろいろないいことがあるかも",
            "中吉：ほしいものが手に入るかも",
            "小吉：まわりのお願いがかなうかも",
            "半吉：果報は寝て待て",
            "末吉：普通な一日。欲張らない方がいいかも",
            "末小吉：ちょっとだけいいことがいいかも",
            "凶：ちょっと今日はついていないかも",
            "小凶：あまりついていない一日。気を付けたほうがいいかも",
            "半凶：いいことが起きそうにない一日",
            "末凶：ついていない一日。あまり無駄使いをしないほうが良いかも",
            "大凶：最悪な一日。おとなしくしておいた方がいいかも"
        };
        public _2_2b_Form()
        {
            InitializeComponent();
        }

        private void pushBotton_Click(object sender, EventArgs e)
        {
            Random Rand = new Random();
            int index = Rand.Next(12);

            MessageBox.Show(this.Name_textBox.Text + "さんの今日の運勢は..." + Environment.NewLine + sarcedLot[index]);
        }
    }
}
