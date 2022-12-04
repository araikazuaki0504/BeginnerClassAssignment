using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] EngToJap = { "月曜日", "火曜日", "水曜日", "木曜日", "金曜日" , "土曜日", "日曜日"  };
            int diffMonday = 0;

            string TodayOfWeek = DateTime.Today.DayOfWeek.ToString();

            switch (TodayOfWeek)
            {
                case "Monday":
                    diffMonday = 0;
                    break;
                case "Tuesday":
                    diffMonday = 1;
                    break;
                case "Wednesday":
                    diffMonday = 2;
                    break;
                case "Thursday":
                    diffMonday = 3;
                    break;
                case "Friday":
                    diffMonday = 4;
                    break;
                case "Saturday":
                    diffMonday = 5;
                    break;
                case "Sunday":
                    diffMonday = 6;
                    break;
            }

            TimeSpan timeSpan =  DateTime.Today - this.dateTimePicker1.Value;
            int WhichDayIndex = (timeSpan.Days + diffMonday) % 7;

            MessageBox.Show("あなたは" + EngToJap[WhichDayIndex] + "生まれです。");
        }
    }
}
