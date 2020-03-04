using System;

namespace Yahtzee
{
    internal class Dice
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