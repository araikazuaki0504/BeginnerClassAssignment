namespace 問題4
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        private void displayButton_Click(object sender, EventArgs e)
        {
            this.textBoxB.Text = this.textBoxA.Text;
            this.textBoxA.Text = string.Empty;
        }
    }
}