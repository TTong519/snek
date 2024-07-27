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
        Game game;
        private void Snek_Load(object sender, EventArgs e)
        {
            bmp = new Bitmap(Screen.Width, Screen.Height);
            gfx = Graphics.FromImage(bmp);
            grid = new Grid();
        }
        Snake snek = new Snake();
        Player player = new Player();
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
            snek.Update(player.states);
            Screen.Image = bmp;
        }
        private void Snek_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                game.player.states = moveState.Left;
            }
            else if (e.KeyCode == Keys.Right)
            {
                game.player.states = moveState.Right;
            }
            if (e.KeyCode == Keys.Down)
            {
                game.player.states = moveState.Up;
            }
            else if (e.KeyCode == Keys.Up)
            {
                game.player.states = moveState.Down;
            }
        }
        private void Snek_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

        }

        
    }
}
