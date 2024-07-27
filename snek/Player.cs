using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snek
{
    public enum moveState
    {
        Up,
        Down,
        Left,
        Right
    }
    public class Player
    {
        public moveState states;
        public Player()
        {
            states = moveState.Up;
        }
    }
}
