namespace 問題75
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            int CurrentYear = DateTime.Today.Year;
            int CurrentMonth = DateTime.Today.Month;

            string LastDay = DateTime.DaysInMonth(CurrentYear, CurrentMonth).ToString();
            this.Label.Text = $"今月は{LastDay}日";
        }
    }
}