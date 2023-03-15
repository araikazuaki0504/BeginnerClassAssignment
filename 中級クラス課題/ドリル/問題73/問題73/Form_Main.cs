namespace 問題73
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            DateTime Today = DateTime.Now;

            this.DateLabel.Text = Today.ToString("yyyy月MM月dd日");
        }
    }
}