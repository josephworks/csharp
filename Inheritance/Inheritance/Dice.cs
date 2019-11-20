using System;

namespace Inheritance
{
    internal class Dice
    {
        private int m_value;
        private int m_sides = 0;
        private Random r = new Random();

        public Dice():this(6)
        {
            
        }

        public Dice(int n)
        {
            m_sides = n;
            System.Threading.Thread.Sleep(10);
            Roll();
        }

        public void Roll()
        {
            m_value = r.Next(1, m_sides + 1);
        }

        public int getValue()
        {
            return m_value;
        }

        public override string ToString()
        {
            return m_value.ToString();
        }
    }
}