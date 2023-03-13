using System.Text;

namespace 問題56
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
            string DisplayMessage = string.Empty;

            //データを取得
            List<string[]> DataTable = GetDataFromText(FilePath);
            //データの整形
            DataTable = To_FormatData(DataTable);

            foreach (string[] DataList in DataTable) 
            {
                DisplayMessage += string.Join(Environment.NewLine, DataList);
                DisplayMessage += Environment.NewLine;
            }
            
            MessageBox.Show(DisplayMessage.TrimEnd());
        }


        /// <summary>
        /// データを整形するメソッド
        /// </summary>
        /// <param name="DataList"></param>
        /// <returns></returns>
        private List<string[]> To_FormatData(List<string[]> DataList)
        {
            int counter = 1;

            for (int Col = 0; Col < DataList.Count; Col++)
            {
                for (int Row = 0; Row < DataList[Col].Length; Row++)
                {
                    DataList[Col][Row] = $"{counter}番 {DataList[Col][Row]}";
                    counter++;
                }
            }

            return DataList;
        }

        private List<string[]> GetDataFromText(string FilePath)
        {
            List<string[]> DataTable = new List<string[]>();
            StreamReader Reader = new StreamReader(FilePath, Encoding.UTF8);

            while (Reader.Peek() > -1)
            {
                DataTable.Add(Reader.ReadLine().Split(" "));
            }

            Reader.Close();
            return DataTable;
        }
    }
}