namespace 問題27
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void displayButton_Click(object sender, EventArgs e)
        {
            string fullName = this.textBoxLastName.Text + this.textBoxFirstName.Text;

            MessageBox.Show("私の名前は" + fullName + "です");
        }
    }
}