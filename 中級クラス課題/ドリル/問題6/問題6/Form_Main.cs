namespace 問題6
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        private void DisplayButton_Click(object sender, EventArgs e)
        {
            string output_Str = this.textBox.Text;
            MessageBox.Show(output_Str);
        }
    }
}