using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final
{
    class Matrix
    {
        int[,] m_a = new int[1, 1];
        public Matrix(int[,] a)
        {
            m_a = a;
        }
        public Matrix scalarMultiply(int n)
        {
            m_a[0, 0] *= n;
            m_a[0, 1] *= n;
            m_a[1, 0] *= n;
            m_a[1, 1] *= n;
            Matrix o = new Matrix(m_a);
            return o;
        }
        public Matrix add(Matrix other)
        {
            m_a[0, 0] += other.m_a[0, 0];
            m_a[0, 1] += other.m_a[0, 1];
            m_a[1, 0] += other.m_a[1, 0];
            m_a[1, 1] += other.m_a[1, 1];
            Matrix o = new Matrix(m_a);
            return o;
        }
        public override string ToString()
        {
            return "|" + m_a[0, 0] + " " + m_a[0, 1] + "|" + "\n" + "|" + m_a[1, 0] + " " + m_a[1, 1] + "|";
        }
    }
}
