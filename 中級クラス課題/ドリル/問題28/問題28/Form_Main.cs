namespace 問題28
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        private void DisplayButton_Click(object sender, EventArgs e)
        {
            string OutputText = string.Empty;

            int Total_Person = int.Parse(this.textBox_maleNum.Text) + int.Parse(this.textBox_femaleNum.Text);

            OutputText = "男性は" + this.textBox_maleNum.Text + "人" + Environment.NewLine +
                         "女性は" + this.textBox_femaleNum.Text + "人" + Environment.NewLine +
                         "合計は" + Total_Person + "人";

            MessageBox.Show(OutputText);
        }
    }
}