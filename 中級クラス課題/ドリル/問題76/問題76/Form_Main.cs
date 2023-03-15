namespace 問題76
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            string RemainingDates = RemainingDatesFromToday();
            this.Label.Text = $"月末まで{RemainingDates}日";
        }

        /// <summary>
        /// 残りの日付を計算するメソッド
        /// </summary>
        /// <returns></returns>
        private string RemainingDatesFromToday()
        {
            int CurrentYear = DateTime.Today.Year;
            int CurrentMonth = DateTime.Today.Month;

            //残っている日にちの計算
            int RemainingDates = DateTime.DaysInMonth(CurrentYear, CurrentMonth) - DateTime.Today.Day;

            return RemainingDates.ToString();
        }
    }
}