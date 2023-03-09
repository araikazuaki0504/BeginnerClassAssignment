namespace 問題22
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
            
            for(int Num = 2; Num <= 100; Num += 2)
            {
                Sum += Num;
            }

            MessageBox.Show(Sum.ToString());
        }
    }
}