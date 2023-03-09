namespace 問題3
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        private void ClickButton_Click(object sender, EventArgs e)
        {
            this.inputTextLabel.Text = this.textBox.Text;
        }
    }
}