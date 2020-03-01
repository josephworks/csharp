using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    class Practice
    {
        int[] m_dice = { 4, 2, 1, 4, 5 };
        public int[] Sort()
        {
            Array.Sort(m_dice);
            return m_dice;
        }
    }
}
