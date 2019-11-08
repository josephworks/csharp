using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yahtzee
{
    class Dice
    {
        private int m_value;
        public void Roll()
        {
            Random r = new Random();
            m_value = r.Next(1, 7);
        }

        public int getValue()
        {
            return m_value;
        }
    }
}
