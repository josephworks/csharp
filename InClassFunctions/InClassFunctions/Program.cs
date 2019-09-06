using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using static System.Console;

namespace InClassFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            double feet;
            double inches;
            double meters;
            double centimeters;
            double l;
            double w;
            double area;
            double per;
            feet = GetValue("How many Feet? ");
            inches = GetValue("How many inches ?");
            l = GetValue("What is the lenght?");
            w = GetValue("What is the width?");
            centimeters = (inches * 2.54) + (feet * 30.48);
            meters = calc(centimeters);
            area = calcarea(l, w);
            per = calcper(l, w);
            output(area, per, meters);
            ReadLine();
        }
        public static void output(double meters, double area, double per)
        {
            WriteLine("Meters: {0:N1}", meters);
            WriteLine("Area: {0:N1} Perimeter: {1:N1}", area, per);
            ReadLine();
        }
        public static double GetValue(string prompt)
        {
            WriteLine(prompt);
            return double.Parse(ReadLine());
        }
        public static double calc(double centimeters)
        {
            return centimeters / 100;
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
