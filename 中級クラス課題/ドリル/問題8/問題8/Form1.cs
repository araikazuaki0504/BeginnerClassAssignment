namespace 問題8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ExchangeButton_Click(object sender, EventArgs e)
        {
            //交換用の代替変数
            string tmp = string.Empty; 

            tmp = this.textBoxA.Text;
            this.textBoxA.Text = this.textBoxB.Text;
            this.textBoxB.Text = tmp;
        }
    }
}