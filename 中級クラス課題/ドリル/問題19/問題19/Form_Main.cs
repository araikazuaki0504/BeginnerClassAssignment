namespace 問題19
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        private void buttonCheck_Click(object sender, EventArgs e)
        {
            int inputNum = int.Parse(this.textBox.Text);

            if (inputNum % 5 == 0)
            {
                MessageBox.Show("5の倍数です");
            }
            else
            {
                MessageBox.Show("5の倍数ではありません");
            }
        }
    }
}