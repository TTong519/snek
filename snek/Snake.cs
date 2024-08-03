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
        public Point[] body = new Point[1];
        int size;
        public Snake()
        {
            body[0] = new Point(4, 4);
        }
        public void Update(moveState st)
        {
            if(st == moveState.Up)
            {
                body[0] = new Point(body[0].X + 1, body[0].Y);
            }
            else if(st == moveState.Down) 
            {
                body[0] = new Point(body[0].X - 1, body[0].Y);
            }
            else if(st == moveState.Left) 
            {
                body[0] = new Point(body[0].X, body[0].Y - 1);
            }
            else
            {
                body[0] = new Point(body[0].X, body[0].Y + 1);
            }
        }
        public void Add()
        {
        }
    }
}