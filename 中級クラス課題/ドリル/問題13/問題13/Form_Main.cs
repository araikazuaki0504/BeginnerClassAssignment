namespace 問題13
{
    public partial class Form_Main : System.Windows.Forms.Form
    {
        public Form_Main()
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