namespace 問題10
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        private void CalButton_Click(object sender, EventArgs e)
        {
            int AnsCalculate = 1980 - 2000;
            MessageBox.Show(AnsCalculate.ToString());
        }
    }
}