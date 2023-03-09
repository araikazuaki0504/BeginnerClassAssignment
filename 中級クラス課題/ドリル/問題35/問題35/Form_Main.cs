namespace 問題35
{
    public partial class Form_Main : System.Windows.Forms.Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            int[,] ArrayData = { { 5, 1, 3, 2, 1 }, { 5, 9, 4, 6, 7 }, { 9, 10, 31, 12, 9 }, { 13, 14, 15, 20, 18, }, { 10, 13, 14, 15, 21 } };
            string OutputText = string.Empty;

            for(int calIndex = 0; calIndex < ArrayData.GetLength(0); calIndex++)
            {
                int max = 0;
                for (int rowIndex = 0; rowIndex < ArrayData.GetLength(1); rowIndex++)
                {
                    if (ArrayData[rowIndex, calIndex] > max) {  max = ArrayData[rowIndex, calIndex];}
                }

                OutputText += (calIndex + 1).ToString() + "行目の最大値 = " + max.ToString() + "です" + Environment.NewLine;
            }

            MessageBox.Show(OutputText);
        }
    }
}