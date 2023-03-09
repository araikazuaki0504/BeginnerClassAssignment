namespace 問題21
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            int Sum = 0;
            for(int Num = 1; Num <= 10; Num++)
            {
                Sum += Num;
            }

            MessageBox.Show(Sum.ToString());
        }
    }
}