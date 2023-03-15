using System.Text;

namespace 問題61
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        private void WriteButton_Click(object sender, EventArgs e)
        {
            string FilePath = @"C:\Users\Public\Documents\order.txt";
            string[] NameList = { "IF太郎", "IF花子", "IF次郎", "IF良子", "IF三郎" };
            string MessageText = WritingToTextFile(FilePath, NameList);

            MessageBox.Show(MessageText);
        }

        private string WritingToTextFile(string FilePath, string[] ListText_ToWrite)
        {
            try
            {
                StreamWriter Writer = new StreamWriter(FilePath, false, Encoding.UTF8);

                for(int Counter = 0; Counter < ListText_ToWrite.Length; Counter++)
                {
                    Writer.Write($"{Counter + 1} {ListText_ToWrite[Counter]}{Environment.NewLine}");
                }

                Writer.Close();
            }
            catch (EncoderFallbackException Error)
            {
                return $"書き込みエラーが発生しました。\nエラーメッセージ:{Error.Source}";
            }

            return $"{Path.GetFileName(FilePath)}に書き込みました";
        }


    }
}