using System.Diagnostics.SymbolStore;
using System.Drawing.Drawing2D;

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
        Bitmap grape;
        bool warp;
        public const int grdsize = 8;
        private void Snek_Load(object sender, EventArgs e)
        {
            ClientSize = new Size(grdsize*100, grdsize*100);
            Screen.Size = new Size(grdsize * 100, grdsize * 100);
            hen = Properties.Resources.Hen;
            chick1 = Properties.Resources.Chick;
            chick2 = Properties.Resources.swan;
            snaek = Properties.Resources.Snek1;
            grape = Properties.Resources.HakopGrape;
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
            for (int i = 0; i < grdsize; i++)
            {
                for (int j = 0; j < grdsize; j++)
                {
                    gfx.FillRectangle(Brushes.White, grid.Squares[i, j].Hitbox);
                }
            }
            snek.Update(player.states);
            if (((snek.body[0].X >= grdsize || snek.body[0].X < 0) || (snek.body[0].Y >= grdsize || snek.body[0].Y < 0)) && !warp)
            {
                tick.Enabled = false;
                label1.BringToFront();
                label1.Text = "Game Over";
                label2.BringToFront();
                label2.Text = "Play Again?";
                return;
            }
            bool isMax = true;
            for (int i = 1; i < Snek.grdsize * Snek.grdsize; i++)
            {
                if (snek.body[i] == new Point(100000, 100000))
                {
                    isMax = false;
                }
                if (snek.body[0] == snek.body[i])
                {
                    tick.Enabled = false;
                    label1.BringToFront();
                    label1.Text = "Game Over";
                    label2.BringToFront();
                    label2.Text = "Play Again?";
                    return;
                }
            }
            if(isMax) 
            {
                tick.Enabled = false;
                label1.BringToFront();
                label1.Text = "win";
                label2.BringToFront();
                label2.Text = "Play Again?";
                return;
            }
            gfx.DrawImage(hen, grid.Squares[snek.body[0].X, snek.body[0].Y].Hitbox);
            for (int i = 1; i < Snek.grdsize*Snek.grdsize; i++)
            {
                if (snek.body[i].X == 100000)
                {
                    continue;
                }
                gfx.DrawImage(chick1, grid.Squares[snek.body[i].X, snek.body[i].Y].Hitbox);
            }
            if (food.isifeaten(snek.body))
            {
                snek.Add();
            }
            gfx.DrawImage(grape, grid.Squares[food.position.X, food.position.Y].Hitbox);
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

        private void Screen_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            bmp = new Bitmap(Screen.Width, Screen.Height);
            gfx = Graphics.FromImage(bmp);
            grid = new Grid();
            snek = new Snake();
            player = new Player();
            food = new food();
            tick.Enabled = true;
            label1.SendToBack();
            label2.SendToBack();
        }
    }
}
