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
        public Point[] body = new Point[10];
        int size;
        public Point last;
        public Point[] lastbody = new Point[10];
        public Snake()
        {
            body[0] = new Point(4, 4);
            body[1] = new Point(4, 5);
            last = new Point(4, 5);
        }
        public void Update(moveState st)
        {
            Point[] body1 = new Point[10];
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
            for(int i = 1; i < 10; i++)
            {
                if (body[i] != null)
                {
                    body1[i] = body[i - 1];
                }
            }
            lastbody = body;
            body = body1;
        }
        public void Add()
        {
            for (int i = 1; i < 10; i++)
            {
                if (body[i] != null)
                {
                    body[i] = last;
                }
            }
        }
    }
}