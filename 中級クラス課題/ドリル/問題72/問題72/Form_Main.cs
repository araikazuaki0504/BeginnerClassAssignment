namespace 問題72
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        private void SumButton_Click(object sender, EventArgs e)
        {
            int InputNum = 0;
            int SumNum = 0;

            int.TryParse(this.TextBoxToSumNum.Text, out InputNum);
            int.TryParse(this.DisplayNumber.Text, out SumNum);

            SumNum -= InputNum;

            this.DisplayNumber.Text = SumNum.ToString();
        }
    }
}