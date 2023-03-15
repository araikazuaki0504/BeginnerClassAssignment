namespace 問題66
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            string[] Names = { "IF太郎", "IF花子", "IF次郎", "IF良子", "IF三郎" };
            string DisplayMessage = string.Empty;
            List<string> NameList = SetNameForList(Names);

            DisplayMessage = string.Join(Environment.NewLine, NameList);

            MessageBox.Show(DisplayMessage);
        }

        private List<string> SetNameForList(string[] Names)
        {
            List<string> NameList = new List<string>();

            foreach (string Name in Names)
            {
                NameList.Add(Name);
            }

            return NameList;
        }
    }
}