using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassIntro
{
    class Point
    {
        int m_x;
        int m_y;
        public Point(int x, int y)
        {
            m_x = x;
            m_y = y;
        }
        public override string ToString()
        {
            return "(" + m_x + "," + m_y + ")";
        }
        public double X() { return m_x; }
        public double Y() { return m_y; }
    }
}