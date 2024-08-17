using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snek
{
    public class Grid
    {
        public Square[,] Squares = new Square[Snek.grdsize, Snek.grdsize];
        public Grid()
        {
            for (int i = 0; i < Snek.grdsize; i++)
            {
                for (int j = 0; j < Snek.grdsize; j++)
                {
                    Squares[i, j] = new(Brushes.White, Snek.grdsize + 100*j, Snek.grdsize + 100*i);
                }
            }
        }
    }
}
    