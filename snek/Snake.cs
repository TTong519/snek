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
        public Point[] body = new Point[Snek.grdsize * Snek.grdsize];
        int size;
        public Point last;
        public Point[] lastbody = new Point[Snek.grdsize*Snek.grdsize];
        public Snake()
        {
            body[0] = new Point(0, 0);
            body[1] = new Point(1, 0);
            for (int i = 2; i < Snek.grdsize; i++)
            {
                body[i] = new Point(100000, 100000);
            }

            last = new Point(0, 1);
        }
        public void Update(moveState st)
        {
            Point[] body1 = new Point[Snek.grdsize* Snek.grdsize];
            if(st == moveState.Up)
            {
                body1[0] = new Point(body[0].X + 1, body[0].Y);
            }
            else if(st == moveState.Down) 
            {
                body1[0] = new Point(body[0].X - 1, body[0].Y);
            }
            else if(st == moveState.Left) 
            {
                body1[0] = new Point(body[0].X, body[0].Y - 1);
            }
            else
            {
                body1[0] = new Point(body[0].X, body[0].Y + 1);
            }
            for(int i = 1; i < Snek.grdsize* Snek.grdsize; i++)
            {
                if (body[i].X != 100000)
                {
                    body1[i] = body[i - 1];
                }
                else
                {
                    body1[i] = new Point(100000, 100000);
                }
            }
            lastbody = body;
            body = body1;
        }
        public void Add()
        {
            for (int i = 1; i < Snek.grdsize * Snek.grdsize; i++)
            {
                if (body[i].X == 100000)
                {
                    body[i] = lastbody[i-1];
                }
            }
        }
    }
}