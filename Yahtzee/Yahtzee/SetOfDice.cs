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

        public Boolean HasNkind(int n)
        {
            int[] vals = new int[5];
            for (int i = 0; i < vals.Length; i++)
            {
                vals[i] = m_dice[i].getValue();
            }
            Array.Sort(vals);
            for (int i = 0; i < 6 - n; i++)
            {
                if (vals[i] == vals[i+1] &&
                    vals[i+1] == vals[i+2])
                {
                    return true;
                }

                for (int j = 0; j < n; j++)
                {
                    if (vals[i] == vals[i + j])
                    {

                    }
                }
            }

            return false;
        }

        public int getvalue(int n)
        {
            return m_dice[n].getValue();
        }

        public override string ToString()
        {
            string retVal = "";
            for (int i = 0; i < m_dice.Length; i++)
            {
                retVal += m_dice[i].getValue() + ",";
            }

            return retVal;
        }
    }
}
