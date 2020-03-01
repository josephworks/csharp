using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            double l;
            double w;
            double a;
            double p;
            l = GetValue("Enter Length:");
            w = GetValue("Enter Width:");
            a = CalcArea(l, w);
            p = CalcPerimeter(l, w);
            Output(a, p);
            ReadLine();
        }
        public static double GetValue(string prompt)
        {
            WriteLine(prompt);
            return double.Parse(ReadLine());
        }
        public static double CalcArea(double l, double w)
        {
            return l * w;
        }
        public static double CalcPerimeter(double l, double w)
        {
            return 2 * (l + w);
        }
        public static void Output(double area, double per)
        {
            WriteLine("Area: {0:N1}, Perimter: {1:N1}", area, per);
        }
    }
}
