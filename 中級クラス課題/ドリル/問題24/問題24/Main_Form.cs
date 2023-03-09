namespace 問題24
{
    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            string OutputText_str = string.Empty;

            for(int hight = 1; hight <= 10;  hight++)
            {
                for(int width = 1; width <= hight; width++)
                {
                    OutputText_str += "*";
                }
                OutputText_str += Environment.NewLine;
            }

            this.textBoxOutput.Text = OutputText_str;
        }
    }
}