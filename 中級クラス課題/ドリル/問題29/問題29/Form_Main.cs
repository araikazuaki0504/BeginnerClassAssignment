namespace 問題29
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            int[] array = { 42, 32, 31, 31, 29 };

            string OutPutText = "四番目の要素は" + array[3].ToString() + "です"; 
            MessageBox.Show(OutPutText);
        }
    }
}