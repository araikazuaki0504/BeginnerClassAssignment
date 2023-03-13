using System.Text;

namespace 問題54
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
            string DisplayMessage = string.Join(Environment.NewLine, DataList).Replace(",", " ");

            MessageBox.Show(DisplayMessage);
        }

        private List<string> GetDataFromText(string FilePath) 
        {
            List<string> DataList = new List<string>();
            StreamReader Reader = new StreamReader(FilePath, Encoding.UTF8);

            while (Reader.Peek() > -1)
            {
                DataList.Add(Reader.ReadLine());
            }

            Reader.Close();

            return DataList;
        }
    }
}