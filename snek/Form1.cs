namespace snek
{
    public partial class Snek : Form
    {
        public Snek()
        {
            InitializeComponent();
        }
        Graphics gfx;
        Bitmap bmp;
        Grid grid;
        private void Snek_Load(object sender, EventArgs e)
        {
            bmp = new Bitmap(Screen.Width, Screen.Height);
            gfx = Graphics.FromImage(bmp);
            grid = new Grid();
        }

        private void tick_Tick(object sender, EventArgs e)
        {
            gfx.Clear(BackColor);
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    gfx.FillRectangle(Brushes.White, grid.Squares[i, j].Hitbox);
                }
            }
            Screen.Image = bmp;
        }
    }
}
