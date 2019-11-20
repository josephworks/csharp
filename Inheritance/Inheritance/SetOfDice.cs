using System;

namespace Inheritance
{
    internal class SetOfDice
    {
        private Dice[] m_dice = new Dice[5];
        private bool[] m_keep = new bool[5];
        private int m_numrolls = 0;

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
            if (m_numrolls == 3)
            {
                return;
            }

            m_numrolls++;
            foreach (Dice d in m_dice)
                for (int i = 0; i < 5; i++)
                {
                    if (!m_keep[i])
                        m_dice[i].Roll();
                }
        }

        public void Reset()
        {
            m_numrolls = 0;
            for (int i = 0; i < m_keep.Length; i++)
            {
                m_keep[i] = false;
            }
        }

        public void Keep(int n)
        {
            m_keep[n] = true;
        }

        public Boolean HasThreeOfAKind()
        {
            int[] vals = new int[5];
            for (int i = 0; i < vals.Length; i++)
            {
                vals[i] = m_dice[i].getValue();
            }
            Array.Sort(vals);
            for (int i = 0; i < 3; i++)
            {
                if (vals[i] == vals[i + 1] &&
                    vals[i + 1] == vals[i + 2])
                {
                    return true;
                }
            }
            return false;
        }

        public Boolean HasFourOfAKind()
        {
            int[] vals = new int[5];
            for (int i = 0; i < vals.Length; i++)
            {
                vals[i] = m_dice[i].getValue();
            }
            Array.Sort(vals);
            for (int i = 0; i < 2; i++)
            {
                if (vals[i] == vals[i + 1] &&
                    vals[i + 1] == vals[i + 2] &&
                    vals[i + 3] == vals[i + 2])
                {
                    return true;
                }
            }
            return false;
        }

        public Boolean HasFiveOfAKind()
        {
            int[] vals = new int[5];
            for (int i = 0; i < vals.Length; i++)
            {
                vals[i] = m_dice[i].getValue();
            }
            Array.Sort(vals);
            for (int i = 0; i < 1; i++)
            {
                if (vals[i] == vals[i + 1] &&
                    vals[i + 1] == vals[i + 2] &&
                    vals[i + 3] == vals[i + 2] &&
                    vals[i + 3] == vals[i + 4])
                {
                    return true;
                }
            }
            return false;
        }

        public bool HasFullHouse()
        {
            int[] vals = new int[5];
            for (int i = 0; i < vals.Length; i++)
            {
                vals[i] = m_dice[i].getValue();
            }
            Array.Sort(vals);
            for (int i = 0; i < 1; i++)
            {
                if (vals[i] == vals[i + 1] &&
                    vals[i + 1] == vals[i + 2] &&
                    vals[i + 3] == vals[i + 4] ||
                    vals[i + 2] == vals[i + 3] &&
                    vals[i + 3] == vals[i + 4] &&
                    vals[i] == vals[i + 1])
                {
                    return true;
                }
            }
            return false;
        }

        public int Getvalue(int n)
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