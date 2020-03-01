using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    class StringStack
    {
        string[] m_s = new string[10];
        int m_count = 0;
        public string peek()
        {
            return m_s[m_count];
        }

        public string pop()
        {
            m_count--;
            return m_s[m_count];
        }

        public void push(string n)
        {
            m_count++;
            m_s[m_count] = n;
        }

        public int size()
        {
            return m_count;
        }
    }
}
