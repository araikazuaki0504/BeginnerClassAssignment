namespace 問題77
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            string ButtonSize_Heigth = this.button.Size.Height.ToString();
            string ButtonSize_Width = this.button.Size.Width.ToString();
            string ButtonPos_X = this.button.Location.X.ToString();
            string ButtonPos_Y = this.button.Location.Y.ToString();

            string DisplayText = $"ボタンの左上の座標は「{ButtonPos_X},{ButtonPos_Y}」\n" +
                                 $"サイズは「幅 = {ButtonSize_Width}」「高さ = {ButtonSize_Heigth}」";

            this.DisplayLabel.Text = DisplayText;


        }
    }
}