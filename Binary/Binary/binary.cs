using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary
{
    class Binary
    {
        int[] m_Data = new int[16];

        public Binary(int num)
        {
            int rem = 0;
            int div = 0;
            for (int i = 0; i < m_Data.Length; i++)
            {
                div = num / 2;
                rem = num % 2;
                m_Data[i] = rem;
                num = div;
            }
        }

        public override string ToString()
        {
            string retVal = "";

            for (int i = 0; i < m_Data.Length; i++)
            {
                retVal = m_Data[i] + retVal;
            }
            return retVal;
        }
    }
}