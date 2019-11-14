using System;

namespace Yahtzee
{
    internal class Dice
    {
        private int m_value;
        private Random r = new Random();

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