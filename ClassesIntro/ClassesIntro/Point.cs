using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesIntro
{
    class Point
    {
        double m_x;
        double m_y;
        public Point(double x, double y)
        {
            m_x = x;
            m_y = y;
        }
        public override string ToString()
        {
            return "(" + m_x +", " + m_y + ")";
        }
        public void Move(double x, double y)
        {
            m_x += x;
            m_y += y;
        }
        public double X() { return m_x; }
        public double Y() { return m_y; }
    }
}
