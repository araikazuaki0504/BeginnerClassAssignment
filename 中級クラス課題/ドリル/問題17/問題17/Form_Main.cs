namespace 問題17
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        private void buttonPlusOrMinus_Click(object sender, EventArgs e)
        {
            int inputNum = int.Parse(textBoxInput.Text);

            if(inputNum > 0)
            {
                this.textBoxOutput.Text = "正の整数です";
            }
            else
            {
                this.textBoxOutput.Text = "負の整数です";
            }
        }
    }
}