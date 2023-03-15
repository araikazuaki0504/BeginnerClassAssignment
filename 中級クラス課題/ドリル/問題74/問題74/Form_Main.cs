namespace 問題74
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            DayOfWeek Day_Of_Week = DateTime.Now.DayOfWeek;

            this.DayOfWeek.Text = ToJapanese_DayOfWeek(Day_Of_Week.ToString());

        }

        private string ToJapanese_DayOfWeek(string English)
        {
            switch (English)
            {
                case "Sunday":
                    return "日曜日";
                case "Monday":
                    return "月曜日";
                case "Tuesday":
                    return "火曜日";
                case "Wednesday":
                    return "水曜日";
                case "Thursday":
                    return "木曜日";
                case "Friday":
                    return "金曜日";
                case "Saturday":
                    return "土曜日";
            }

            return English;
        }
    }
}