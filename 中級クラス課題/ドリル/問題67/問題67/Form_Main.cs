using System.Collections;
using System.Text;

namespace 問題67
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            string FilePath = @"C:\Users\Public\Documents\name.txt";
            string DisplayMessage = string.Empty;
            ArrayList NameList = ReadDataFromText(FilePath);

            DisplayMessage = string.Join(Environment.NewLine, NameList.ToArray());

            MessageBox.Show(DisplayMessage);
        }

        private ArrayList ReadDataFromText(string FilePath)
        {
            ArrayList NamesList = new ArrayList();
            StreamReader Reader = new StreamReader(FilePath, Encoding.UTF8);

            while(Reader.Peek() > -1)
            {
                NamesList.Add(Reader.ReadLine());
            }

            Reader.Close();
            return NamesList;
        }
    }
}