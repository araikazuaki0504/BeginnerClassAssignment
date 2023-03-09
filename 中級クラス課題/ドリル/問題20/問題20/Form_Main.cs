namespace 問題20
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        private void buttonCheck_Click(object sender, EventArgs e)
        {
            int[] inputNum = new int[5];

            inputNum[0] = int.Parse(this.textBoxFirst.Text);
            inputNum[1] = int.Parse(this.textBoxSecond.Text);
            inputNum[2] = int.Parse(this.textBoxThird.Text);
            inputNum[3] = int.Parse(this.textBoxFourth.Text);
            inputNum[4] = int.Parse(this.textBoxFifth.Text);

            int MaxNum = MaxNumber(inputNum);

            MessageBox.Show("最大値は" +  MaxNum.ToString() + "です.");
        }

        private int MaxNumber(int[] inputNum)
        {
            int MaxNumber = int.MinValue;

            foreach (int number in inputNum) 
            {
                if(number > MaxNumber) MaxNumber = number;
            }

            return MaxNumber;
        }
    }
}