namespace 問題25
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        private void DisplayButton_Click(object sender, EventArgs e)
        {
            string linkedWord = this.textBox_Left.Text + this.textBox_Right.Text;

            this.OutputTextLabel.Text = linkedWord;
        }
    }
}