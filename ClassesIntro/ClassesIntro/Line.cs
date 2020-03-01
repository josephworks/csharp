using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesIntro
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
            return m_p1 + ", " + m_p2 + " Slope = " + Slope() + " Length = " + Length();
        }
        public double Slope()
        {
            return (m_p2.Y() - m_p1.Y()) / (m_p2.X() - m_p1.X());
        }
        public double Length()
        {
            double xdist = m_p2.X() - m_p1.X();
            double ydist = m_p2.Y() - m_p1.Y();
            return Math.Sqrt(xdist * xdist + ydist * ydist);
        }
    }
}
