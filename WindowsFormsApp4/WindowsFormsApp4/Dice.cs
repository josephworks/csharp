using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4
{
    class Dice
    {
        private int m_value;
        Random r = new Random();
        public Dice()
        {
            System.Threading.Thread.Sleep(10);
            Roll();
        }
        public void Roll()
        {
            m_value = r.Next(1, 7);
        }
        public int getValue()
        {
            return m_value;
        }
    }
}
