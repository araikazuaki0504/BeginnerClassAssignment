namespace 問題30
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            string[] ArrayData = { "鈴木一郎", "山田花子", "佐藤良子", "田中次郎", "伊藤太郎" };

            string outputText = "二番目の要素は" + ArrayData[1] + "です";

            MessageBox.Show(outputText);
        }
    }
}