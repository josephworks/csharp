using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace MethodsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            double l;
            double w;
            double area;
            double per;
            l = GetValue("What is the lenght?");
            w = GetValue("What is the width?");
            area = calcarea(l, w);
            per = calcper(l, w);
            output(area, per);
            ReadLine();
        }
        public static void output(double area, double per)
        {
            WriteLine("Area: {0:N1} Perimeter: {1:N1}", area, per);
        }
        public static double GetValue(string prompt)
        {
            WriteLine(prompt);
            return double.Parse(ReadLine());
        }
        public static double calcarea(double l, double w)
        {
            return l * w;
        }
        public static double calcper(double l, double w)
        {
            return 2 * (l + w);
        }
    }
}
