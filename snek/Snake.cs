using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snek
{
    public class Snake
    {
        Point prevTail;
        Point[] body;
        Brush[,] draw;
        public Snake(Point hlok, Point tlok)
        {
            for(int i = 0; i < 8;  i++)
            {
                for(int j = 0; j < 8; j++)
                {
                    if(hlok.X == i && hlok.Y == j)
                    {
                        draw[i, j] = Brushes.Black;
                    }
                    if(tlok.X == i && tlok.Y == j)
                    {
                        draw[i, j] = Brushes.Black;
                    }
                }
            }
        }
        public void update()
        {

        }
        public void add()
        {
            Point temp = tail;
            tail = prevTail;
            prevTail = temp;
        }
    }
}