using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snek
{
    internal class food
    {
        Random random = new Random();
        public Point position;
        public food()
        {
            position = new Point(random.Next(Snek.grdsize), random.Next(Snek.grdsize));
        }
        public bool isifeaten(Point[] body) 
        {
            if (position == body[0])
            {
                Point newpos = new Point(random.Next(Snek.grdsize), random.Next(Snek.grdsize));
                while(body.Contains(newpos))
                {
                    newpos = new Point(random.Next(Snek.grdsize), random.Next(Snek.grdsize));
                }
                position = newpos;
                return true;
            }
            return false;
        }
    }
}
