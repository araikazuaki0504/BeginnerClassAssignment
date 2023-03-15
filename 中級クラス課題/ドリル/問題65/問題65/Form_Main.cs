using System.Collections;

namespace 問題65
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            int MaxNumber = 10;
            ArrayList Numbers = SetNumbers(MaxNumber);
            int SumNumbers = Sum(Numbers);

            MessageBox.Show($"1～{MaxNumber.ToString()}までの合計した結果は{SumNumbers.ToString()}です。");
        }

        private ArrayList SetNumbers(int MaxNum)
        {
            ArrayList Numbers = new ArrayList();

            for (int Number = 1; Number <= MaxNum; Number++)
            {
                Numbers.Add(Number);
            }
            return Numbers;
        }

        private int Sum(ArrayList Numbers)
        {
            int Sum = 0;

            foreach (int Number in Numbers)
            {
                Sum += Number;
            }

            return Sum;
        }
    }
}