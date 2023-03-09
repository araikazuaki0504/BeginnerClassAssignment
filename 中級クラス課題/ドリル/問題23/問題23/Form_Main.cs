namespace 問題23
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            string AnsText_str = string.Empty;
            for (int firsstNum = 1; firsstNum <= 9; firsstNum++)
            {
                for (int secondNum = 1; secondNum <= 9; secondNum++)
                {
                    int Ans_int = firsstNum * secondNum;
                    if (secondNum == 9) 
                    {
                        AnsText_str += Ans_int.ToString();
                    }
                    else
                    {
                        AnsText_str += Ans_int.ToString() + ",";
                    }
                }
                AnsText_str += Environment.NewLine;
            }

            this.textBox_Output.Text = AnsText_str;
        }
    }
}