namespace 問題11
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        private void CalButton_Click(object sender, EventArgs e)
        {
            int AnsCalculate = 198 * 200;
            MessageBox.Show(AnsCalculate.ToString());
        }
    }
}