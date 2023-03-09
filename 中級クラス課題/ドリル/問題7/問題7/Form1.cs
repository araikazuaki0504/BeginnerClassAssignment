namespace 問題7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ExchangeButton_Click(object sender, EventArgs e)
        {
            /// <summary>
            /// 交換用の代替変数
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            string tmp = string.Empty;

            tmp = this.LeftLabel.Text;
            this.LeftLabel.Text = this.RightLabel.Text;
            this.RightLabel.Text = tmp;
        }
    }
}