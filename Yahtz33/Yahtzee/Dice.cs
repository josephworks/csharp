using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yahtzee
{
    class Dice
    {
        public int Roll()
        {
            Random r = new Random();
             return r.Next(0, 6);
        }
        public int Value()
        {
            return Roll();
        }
    }
}
