using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassIntro
{
    class Line
    {
        Point m_p1;
        Point m_p2;
        public Line(Point p1, Point p2)
        {
            m_p1 = p1;
            m_p2 = p2;
        }
        public override string ToString()
        {
            return m_p1 + "," + m_p2;
        }
        public double slope()
        {
            return
        }
    }
}
