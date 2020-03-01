using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yahtzee
{
    class SetofDice
    {
        Dice[] d = new Dice[5];
        public void Roll()
        {
            for (int i = 0; i < d.Length; i++)
            {
                d[i].Roll();
            }
        }
        public int score()
        {
            return d[1].Value() + d[2].Value() + d[3].Value() + d[4].Value() + d[5].Value();
        }

    }
}
