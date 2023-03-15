using System.Text;

namespace 問題57
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        private void WriteButton_Click(object sender, EventArgs e)
        {
            string FilePath = @"C:\Users\Public\Documents\name.txt";
            string MessageText = WritingToTextFile(FilePath, "IF太郎");

            MessageBox.Show(MessageText);
        }

        private string WritingToTextFile(string FilePath, string Text_ToWrite)
        {
            try
            {
                StreamWriter Writer = new StreamWriter(FilePath, false, Encoding.UTF8);

                Writer.WriteLine(Text_ToWrite);

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