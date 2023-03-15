using System.Text;

namespace 問題63
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
            List<string> NameList = GetListNameFromListBox();
            string MessageText = WritingToTextFile(FilePath, NameList);

            MessageBox.Show(MessageText);
        }

        private List<string> GetListNameFromListBox()
        {
            List<string> ListName = new List<string>();

            foreach (string Name in this.listBox.Items)
            {
                ListName.Add(Name);
            }

            return ListName;
        }

        private string WritingToTextFile(string FilePath, List<string> ListText_ToWrite)
        {
            try
            {
                StreamWriter Writer = new StreamWriter(FilePath, false, Encoding.UTF8);

                for (int Counter = 0; Counter < ListText_ToWrite.Count; Counter++)
                {
                    Writer.Write($"{ListText_ToWrite[Counter]}{Environment.NewLine}");
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