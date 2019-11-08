using System;

namespace Yahtzee
{
    class SetOfDice
    {
        Dice[] m_dice = new Dice[5];
        //Put shoes in box
        public SetOfDice()
        {
            for (int i = 0; i < m_dice.Length; i++)
            {
                m_dice[i] = new Dice();
            }
        }
        public void Roll()
        {
            foreach (Dice d in m_dice)
            {
                d.Roll();
            }
        }

        public Boolean Hasthreeofakind()
        {
            int[] vals = new int[5];
            for (int i = 0; i < vals.Length; i++)
            {
                vals[i] = m_dice[i].getValue();
            }
            Array.Sort(vals);
            for (int i = 0; i < 3; i++)
            {
                if (vals[i] == vals[i+1] &&
                    vals[i+1] == vals[i+2])
                {
                    return true;
                }
            }

            return false;
        }

        public int getvalue(int n)
        {
            return m_dice[n].getValue();
        }
    }
}
