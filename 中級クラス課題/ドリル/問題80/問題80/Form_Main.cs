namespace 問題80
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        private void checkBox_AvailableButton_CheckedChanged(object sender, EventArgs e)
        {
            this.button.Enabled = this.button.Enabled ? false : true;
        }
    }
}