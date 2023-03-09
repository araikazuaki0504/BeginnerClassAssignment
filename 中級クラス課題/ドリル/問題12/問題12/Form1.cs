namespace 問題12
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        private void CalButton_Click(object sender, EventArgs e)
        {
            int ansCalculate = 200 / 10;
            MessageBox.Show(ansCalculate.ToString());
        }
    }
}