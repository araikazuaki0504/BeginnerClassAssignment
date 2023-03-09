namespace 問題9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalButton_Click(object sender, EventArgs e)
        {
            int Anscalculate = 1980 + 2000; 
            MessageBox.Show(Anscalculate.ToString());
        }
    }
}