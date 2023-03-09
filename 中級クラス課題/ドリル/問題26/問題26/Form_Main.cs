namespace 問題26
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        private void button_Left_Click(object sender, EventArgs e)
        {
            string linkedword = this.textBoxLeft.Text + "+" + this.textBoxRight.Text + "=" + this.textBoxLeft.Text + textBoxRight.Text;
            this.OutputText_label.Text = linkedword;
        }
    }
}