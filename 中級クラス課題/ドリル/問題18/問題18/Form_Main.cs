namespace 問題18
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        private void buttonCompare_Click(object sender, EventArgs e)
        {
            int maxNum = MaxNum(int.Parse(this.textBoxFirst.Text), int.Parse(this.textBoxSecond.Text));

            this.textBoxMax.Text = maxNum.ToString();
        }

        /// <summary>
        /// 大きいほうを返す関数
        /// </summary>
        /// <param name="firstNum"></param>
        /// <param name="secondNum"></param>
        /// <returns></returns>
        private int MaxNum(int firstNum, int secondNum)
        {
            if(firstNum > secondNum)
            {
                return firstNum;
            }
            else
            {
                return secondNum;
            }
        }
    }
}