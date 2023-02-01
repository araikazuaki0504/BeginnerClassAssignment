using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2_8
{
    public partial class Form_Main : Form
    {
        int money = 10000;

        public Form_Main()
        {
            InitializeComponent();
            this.Money_textBox.Text = money.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.BetMoney_textBox.Enabled = true;
            this.Daice_button.Enabled = true;
            this.OddOrEven_comboBox.Enabled = true;
            this.Reset_button.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random Rand = new Random();
            //RandomNum[2]が合計
            int[] RandomNum = new int[3];
            string outPutString = string.Empty;

            for (int i = 0; i < 2; i++)
            {
                RandomNum[i] = Rand.Next(1, 7);
                RandomNum[2] += RandomNum[i];
            }
            
            if (RandomNum[2] % 2 == 0 && this.OddOrEven_comboBox.SelectedItem.ToString() == "偶数")
            {
                outPutString = RandomNum[0].ToString() + "-" + RandomNum[2] + "の偶数" + Environment.NewLine + "勝ちです";
                this.money += int.Parse(this.BetMoney_textBox.Text);
            }
            else if (RandomNum[2] % 2 == 1 && this.OddOrEven_comboBox.SelectedItem.ToString() == "奇数")
            {
                outPutString = RandomNum[0].ToString() + "-" + RandomNum[2] + "の奇数" + Environment.NewLine + "勝ちです";
                this.money += int.Parse(this.BetMoney_textBox.Text);
            }
            else
            {
                outPutString = RandomNum[0].ToString() + "-" + RandomNum[2] + "の" + this.OddOrEven_comboBox.SelectedItem.ToString() + Environment.NewLine + "負けです";
                this.money -= int.Parse(this.BetMoney_textBox.Text);
            }

            if (this.money <= 0)
            {
                MessageBox.Show("ゲームオーバー");
            }

            this.Result_label.Text = outPutString;
            this.Money_textBox.Text = money.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.money = 10000;
            this.BetMoney_textBox.Enabled = false;
            this.Daice_button.Enabled = false;
            this.OddOrEven_comboBox.Enabled = false;
            this.Reset_button.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult result =  MessageBox.Show("ゲームを終了しますか？よろしいですか？","gゲームの終了確認" ,MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            
            if (result == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}
