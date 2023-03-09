namespace 問題33
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            int[,] ArrayData = { { 1, 2, 3, 4, 5 }, { 5, 6, 7, 8, 9 }, { 9, 10, 11, 12, 13 }, { 13, 14, 15, 16, 17 }, { 17, 18, 19, 20, 21 } };

            string outPutText = string.Empty;

            for(int calIndex = 0;  calIndex < ArrayData.GetLength(0); calIndex++)
            {
                int CalSum = 0;

                for(int rowIndex = 0;  rowIndex < ArrayData.GetLength(1); rowIndex++)
                {
                    CalSum += ArrayData[calIndex, rowIndex];    
                }

                outPutText += (calIndex + 1).ToString() + "行目の合計は" + CalSum + "です" + Environment.NewLine;
            }

            MessageBox.Show(outPutText);
        }
    }
}