namespace 問題79
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        private void button_LeftArrow_Click(object sender, EventArgs e)
        {
            MovingStar(-10);
        }
        private void button_RightArrow_Click(object sender, EventArgs e)
        {
            MovingStar(10);
        }

        /// <summary>
        /// Star_Labelを引数分動かすメソッド
        /// </summary>
        /// <param name="dx">xの変位</param>
        private void MovingStar(int dx)
        {
            int Pos_X = dx + this.StarLabel.Location.X;
            int Pos_Y = this.StarLabel.Location.Y;
            Point NextPos = new Point(Pos_X, Pos_Y);

            this.StarLabel.Location = NextPos;
        }
    }
}