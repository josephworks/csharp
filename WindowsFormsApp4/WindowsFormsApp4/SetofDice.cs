using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4
{
    class SetofDice
    {
        Dice[] m_dice = new Dice[5];
        bool[] m_keep = new bool[5];
        int m_numrolls = 0;
        public SetofDice()
        {
            for (int i = 0; i < m_dice.Length; i++)
            {
                m_dice[i] = new Dice();
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
        public void Roll()
        {
            if (m_numrolls == 3)
                return;
            m_numrolls++;
            for (int i = 0; i < 5; i++)
            {
                if (!m_keep[i])
                    m_dice[i].Roll();
            }
        }
        public bool threeOfaKind()
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
        public bool fourOfaKind()
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
                    vals[i + 2] == vals[i + 3])
                {
                    return true;
                }
            }
            return false;
        }
        public bool Yahtzee()
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
                    vals[i + 2] == vals[i + 3] &&
                    vals[i + 3] == vals[i + 4])
                {
                    return true;
                }
            }
            return false;
        }
        public bool fullHouse()
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
        public bool largeStraight()
        {
            int[] vals = new int[5];
            for (int i = 0; i < vals.Length; i++)
            {
                vals[i] = m_dice[i].getValue();
            }
            Array.Sort(vals);
            if (vals[0] == 1 &&
            vals[1] == 2 &&
            vals[2] == 3 &&
            vals[3] == 4 &&
            vals[4] == 5 ||
            vals[0] == 2 &&
            vals[1] == 3 &&
            vals[2] == 4 &&
            vals[3] == 5 &&
            vals[4] == 6)
            {
                return true;
            }
            return false;
        }
        public bool smallStraight()
        {
            int[] vals = new int[5];
            for (int i = 0; i < vals.Length; i++)
            {
                vals[i] = m_dice[i].getValue();
            }
            Array.Sort(vals);
            for (int i = 0; i < 4; i++)
            {
                int temp = 0;
                if (vals[i] == vals[i + 1])
                {
                    temp = vals[i];

                    for (int k = i; k < 4; k++)
                    {
                        vals[k] = vals[k + 1];
                    }

                    vals[4] = temp;
                }
            }
            if (((vals[0] == 1) && (vals[1] == 2) && (vals[2] == 3) && (vals[3] == 4)) ||
                ((vals[0] == 2) && (vals[1] == 3) && (vals[2] == 4) && (vals[3] == 5)) ||
                ((vals[0] == 3) && (vals[1] == 4) && (vals[2] == 5) && (vals[3] == 6)) ||
                ((vals[1] == 1) && (vals[2] == 2) && (vals[3] == 3) && (vals[4] == 4)) ||
                ((vals[1] == 2) && (vals[2] == 3) && (vals[3] == 4) && (vals[4] == 5)) ||
                ((vals[1] == 3) && (vals[2] == 4) && (vals[3] == 5) && (vals[4] == 6)))
            {
                return true;
            }

            return false;
        }
        public int getValue(int n)
        {
            return m_dice[n].getValue();
        }
        public override string ToString()
        {
            string retVal = "";
            for (int i = 0; i < m_dice.Length; i++)
            {
                retVal += m_dice[i].getValue() + ", ";
            }
            return retVal;
        }
        public int score()
        {
            int sum = 0;
            foreach (Dice d in m_dice)
            {
                sum += d.getValue();
            }
            return sum;
        }
    }
}
