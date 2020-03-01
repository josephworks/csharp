using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleFramework
{
    public class Fraction
    {
        int m_num;
        int m_denom;

        public int GCDRecursive(int a, int b)
        {
            if (a == 0)
                return b;
            if (b == 0)
                return a;

            if (a > b)
                return GCDRecursive(a % b, b);
            else
                return GCDRecursive(a, b % a);
        }
        public Fraction(int numer, int denom)
        {
            int gcd = GCDRecursive(numer, denom);
            m_num = numer / gcd;
            m_denom = denom / gcd;
        }

        public Fraction add(Fraction other)
        {
            int num1;
            int num2;
            int denom;
            num1 = m_num * other.m_denom;
            num2 = other.m_num * m_denom;
            denom = m_denom * other.m_denom;
            return new Fraction(num1 + num2, denom);
        }
        public Fraction subtract(Fraction other)
        {
            int num1;
            int num2;
            int denom;
            num1 = m_num * other.m_denom;
            num2 = other.m_num * m_denom;
            denom = m_denom * other.m_denom;
            return new Fraction(num1 - num2, denom);
        }
        public Fraction multiply(Fraction other)
        {
            int num;
            int denom;
            num = m_num * other.m_num;
            denom = m_denom * other.m_denom;
            return new Fraction(num, denom);
        }
        public Fraction divide(Fraction other)
        {
            int num;
            int denom;
            num = m_num * other.m_denom;
            denom = m_denom * other.m_num;
            return new Fraction(num, denom);
        }
        public override string ToString()
        {
            return m_num + "/" + m_denom;
        }
    }
}
