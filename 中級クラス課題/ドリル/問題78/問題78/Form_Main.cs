namespace 問題78
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        private void ExpandButton_Click(object sender, EventArgs e)
        {
            Size TimesSize = new Size(this.ExpandButton.Width, this.ExpandButton.Height);
            this.ExpandButton.Size += TimesSize;
        }
    }
}