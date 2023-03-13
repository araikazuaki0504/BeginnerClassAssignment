using System.IO;
using System.Text;

namespace 問題51
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
            List<string> GetData = GetDataFromText(FilePath);
            string DisplayText = string.Join("\n", GetData);   
            
            MessageBox.Show(DisplayText);
        }

        private List<string> GetDataFromText(string FilePath)
        {
            List<string> GetData = new List<string>();
            StreamReader Reader = new StreamReader(FilePath, Encoding.UTF8);

            while(Reader.Peek() > -1)
            {
                string[] OneLineData = Reader.ReadLine().Split(" ");
                
                foreach(string Data in OneLineData)
                {
                    GetData.Add(Data);
                }
            }

            Reader.Close();

            return GetData;
        }
    }
}