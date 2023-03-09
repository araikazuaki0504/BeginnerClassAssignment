namespace 問題14
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            int ansCalculate = int.Parse(this.textBoxFirst.Text) + int.Parse(this.textBoxSecond.Text);

            this.textBoxAns.Text = ansCalculate.ToString();
        }
    }
}