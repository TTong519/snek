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
        Bitmap hen;
        Bitmap chick1;
        Bitmap chick2;
        Bitmap snaek;
        private void Snek_Load(object sender, EventArgs e)
        {
            hen = Properties.Resources.Hen;
            chick1 = Properties.Resources.Chick;
            chick2 = Properties.Resources.swan;
            snaek = Properties.Resources.Snek1;
            bmp = new Bitmap(Screen.Width, Screen.Height);
            gfx = Graphics.FromImage(bmp);
            grid = new Grid();
        }
        Snake snek = new Snake();
        Player player = new Player();
        food food = new food();
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
            gfx.DrawImage(hen, grid.Squares[snek.body[0].X, snek.body[0].Y].Hitbox);
            for(int i = 1;i < 63;i++)
            {
                if (snek.body[i].X == 100000)
                {
                    continue;
                }
                gfx.DrawImage(chick1, grid.Squares[snek.body[i].X, snek.body[i].Y].Hitbox);
            }
            if (food.isifeaten(snek.body[0]))
            {
                snek.Add();
            }
            gfx.DrawImage(snaek, grid.Squares[food.position.X, food.position.Y].Hitbox);
            Screen.Image = bmp;
        }
        private void Snek_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                player.states = moveState.Left;
            }
            else if (e.KeyCode == Keys.Right)
            {
                player.states = moveState.Right;
            }
            if (e.KeyCode == Keys.Down)
            {
                player.states = moveState.Up;
            }
            else if (e.KeyCode == Keys.Up)
            {
                player.states = moveState.Down;
            }
        }
        private void Snek_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

        }
    }
}
