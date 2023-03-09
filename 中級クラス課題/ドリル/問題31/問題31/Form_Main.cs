namespace 問題31
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            int[] arrayData = { 10, 15, 32, 8, 20 };

            int DataMean = Mean(arrayData);

            string OutputText = "平均は" + DataMean.ToString() + "です";

            MessageBox.Show(OutputText);
        }

        int Mean(int[] DataArray)
        {
            int Sum = 0;

            for (int index = 0; index < DataArray.Length; index++)
            {
                Sum += DataArray[index];
            }
      
            return Sum / DataArray.Length;
        }
    }
}