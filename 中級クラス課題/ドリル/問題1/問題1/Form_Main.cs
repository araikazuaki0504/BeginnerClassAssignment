namespace 問題1
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        private void Click_Button(object sender, EventArgs e)
        {
            this.HelloLabel.Text = "Hello!";
        }
    }
}