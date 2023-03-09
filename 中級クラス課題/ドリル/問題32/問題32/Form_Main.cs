namespace 問題32
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            string[] arrayData = { "鈴木一郎", "山田花子", "佐藤良子", "田中次郎", "斎藤太郎" };
            string outputText = string.Empty;

            for(int Counter = 1; Counter <= arrayData.Length; Counter++)
            {
                outputText += Counter.ToString() + "番" + arrayData[Counter - 1].ToString() + Environment.NewLine;
            }

            MessageBox.Show(outputText);
        }
    }
}