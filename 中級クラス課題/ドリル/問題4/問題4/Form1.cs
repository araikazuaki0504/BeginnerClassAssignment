namespace 問題4
{
    public partial class Form1 : Form
    {
        public Form1()
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