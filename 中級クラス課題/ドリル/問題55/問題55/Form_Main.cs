using System.Text;

namespace 問題55
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
            List<string> DataList = GetDataFromText(FilePath);

            //○番をそれぞれにつける
            for(int Counter =  0; Counter < DataList.Count; Counter++)
            {
                DataList[Counter] = $"{Counter + 1}番 {DataList[Counter]}";
            }

            string DisplayMessage = string.Join(Environment.NewLine, DataList);
            MessageBox.Show(DisplayMessage);
        }

        private List<string> GetDataFromText(string FilePath)
        {
            List<string> DataList = new List<string>();
            StreamReader Reader = new StreamReader(FilePath, Encoding.UTF8);

            while(Reader.Peek() > -1) 
            {
                DataList.Add(Reader.ReadLine());
            }

            Reader.Close();
            return DataList;
        }
    }
}