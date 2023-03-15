namespace 問題36
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            string[] nameOfMonth = { "睦月", "如月", "弥生", "卯月", "皐月", "水無月", "文月", "葉月", "長月", "神無月", "霜月", "師走" };
            int InputMonth = int.Parse(this.textBox.Text);

            if (1 <= InputMonth && InputMonth <= 12)
            {
                MessageBox.Show(nameOfMonth[InputMonth]);
            }
        }
    }
}