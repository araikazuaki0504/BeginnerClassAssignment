using System.Text;

namespace 問題52
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        private void ReadButton_Click(object sender, EventArgs e)
        {
            string FilePath = @"C:\Users\Public\Documents\name.txt";
            List<string> Data = GetReadFromText(FilePath);
            string DisplayText = string.Join("\n", Data);

            MessageBox.Show(DisplayText);

        }

        private List<string> GetReadFromText(string FilePath)
        {
            List<string> GetData = new List<string>();
            StreamReader Reader = new StreamReader(FilePath, Encoding.UTF8);

            while(Reader.Peek() > -1)
            {
                string[] LineData = Reader.ReadLine().Split(",");

                foreach(string Data in LineData) 
                {
                    GetData.Add(Data);
                }
            }

            Reader.Close();

            return GetData;
        }
    }
}