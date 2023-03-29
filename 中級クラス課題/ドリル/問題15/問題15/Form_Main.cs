namespace 問題15
{
    public partial class Form_Main : System.Windows.Forms.Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }


        private void buttonTimes_Click(object sender, EventArgs e)
        {
            int ansCalculate = Calculate("*");
            this.labelOperate.Text = "×";
            this.textBoxAns.Text = ansCalculate.ToString();
        }

        private void buttonDiv_Click(object sender, EventArgs e)
        {
            int ansCalculate = Calculate("/");
            this.labelOperate.Text = "÷";
            this.textBoxAns.Text = ansCalculate.ToString();
        }

        /// <summary>
        ///演算子によって計算を変える関数 
        /// </summary>
        /// <param name="Operater"></param>
        /// <returns></returns>
        private int Calculate(string Operater)
        {
            switch (Operater)
            {
                case "*":
                    return int.Parse(this.textBoxFirst.Text) * int.Parse(this.textBoxSecond.Text);
                case "/":
                    return int.Parse(this.textBoxFirst.Text) / int.Parse(this.textBoxSecond.Text);
            }

            MessageBox.Show("演算子が間違っています");
            return 0;
        }
    }
}