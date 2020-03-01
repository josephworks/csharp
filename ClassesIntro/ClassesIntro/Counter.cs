using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesIntro
{
    class Counter
    {
        int m_count;
        string m_name;
        public Counter(string name)
        {
            m_count = 0;
            m_name = name;
        }
        public void Click()
        {
            m_count++;
        }
        public void Reset()
        {
            m_count = 0;
        }
        public int getValue()
        {
            return m_count;
        }
        public override string ToString()
        {
            return m_name + ": " + m_count;
        }
    }
}
