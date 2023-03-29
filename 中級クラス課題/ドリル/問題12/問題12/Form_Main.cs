namespace 問題12
{
    public partial class Form_Main : System.Windows.Forms.Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        private void CalButton_Click(object sender, EventArgs e)
        {
            int AnsCalculate = 200 / 10;
            MessageBox.Show(AnsCalculate.ToString());
        }
    }
}