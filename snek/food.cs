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
            position = new Point(random.Next(8), random.Next(8));
        }
        public bool isifeaten(Point head) 
        {
            if (position == head)
            {
                position = new Point(random.Next(8), random.Next(8));
                return true;
            }
            return false;
        }
    }
}
