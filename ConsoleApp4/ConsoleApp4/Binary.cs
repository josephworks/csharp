using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Binary
    {
        int[] m_data = new int[16];
        public Binary(int num)
        {
            int rem = 0;
            int div = 0;
            for (int i = 0; i < m_data.Length; i++)
            {
                div = num / 2;
                rem = num % 2;
                m_data[i] = rem;
                num = div;
            }
        }
        public override string ToString()
        {
            string retVal = "";
            for (int i = 0; i < m_data.Length; i++)
            {
                retVal = m_data[i] + retVal;
            }
            return retVal;
        }
        public string toOctal()
        {
            string retVal = "";
            for (int i = 0; i < m_data.Length; i++)
            {
                retVal = m_data[i] + retVal;
            }
            return retVal;
        }
    }
}
