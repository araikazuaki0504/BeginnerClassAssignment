using System.Text;

namespace 問題68
{
    public partial class Fomr_Main : Form
    {
        public Fomr_Main()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            string FilePath = @"C:\Users\Public\Documents\name.txt";
            string DisplayMessage = string.Empty;
            List<string> NameList = ReadDataFromText(FilePath);
            List<string> AttachedNamesList = attachingNumberToNames(NameList);

            DisplayMessage = string.Join(Environment.NewLine, AttachedNamesList);

            MessageBox.Show(DisplayMessage);
        }

        private List<string> attachingNumberToNames(List<string> names)
        {
            List<string> AttachedNamesList = new List<string>();

            for(int counter = 0; counter < names.Count; counter++)
            {
                string AttachedName = $"{counter + 1}番 {names[counter]}";
                AttachedNamesList.Add(AttachedName);
            }

            return AttachedNamesList;
        }

        private List<string> ReadDataFromText(string FilePath)
        {
            List<string> NamesList = new List<string>();
            StreamReader Reader = new StreamReader(FilePath, Encoding.UTF8);

            while (Reader.Peek() > -1)
            {
                NamesList.Add(Reader.ReadLine());
            }

            Reader.Close();
            return NamesList;
        }
    }
}