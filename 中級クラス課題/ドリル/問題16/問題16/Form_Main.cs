namespace 問題16
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        private void buttonMean_Click(object sender, EventArgs e)
        {
            int mean = (int.Parse(textBoxFirst.Text) + int.Parse(textBoxSecond.Text) + int.Parse(textBoxThird.Text) + int.Parse(textBoxFourth.Text) + int.Parse(this.textBoxFifth.Text)) / 5;

            this.textBoxMean.Text = mean.ToString();
        }
    }
}