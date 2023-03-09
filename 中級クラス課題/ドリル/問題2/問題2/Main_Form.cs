namespace 問題2
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        private void XButton_Click(object sender, EventArgs e)
        {
            this.ClickButtonNameLabel.Text = "Xのボタンをクリック";
        }

        private void YButton_Click(object sender, EventArgs e)
        {
            this.ClickButtonNameLabel.Text = "Yのボタンをクリック";
        }
    }
}