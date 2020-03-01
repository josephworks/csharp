using System;
using static System.Console;

namespace Area_Calculators
{
    class Program
    {
        static void Main(string[] args)
        {
            int calc;
            WriteLine("What would you like to calculate?");
            WriteLine("Type 1 for circle, 2 for rectangle, 3 for trapezoid, 4 for cylinder");
            calc = int.Parse(ReadLine());
            switch (calc)
            {
                case 1:
                    int r;
                    r = getInput("Enter radius");
                    WriteLine("Area: " + calcCircle(r));
                    break;
                case 2:
                    int l = getInput("Enter length");
                    int w = getInput("Enter width");
                    WriteLine("Area: " + calcRectangle(l, w));
                    break;
                case 3:
                    double b1 = getInput("Enter base 1");
                    double b2 = getInput("Enter base 2");
                    double h = getInput("Enter height");
                    WriteLine("Area: " + calcTrapezoid(b1, b2, h));
                    break;
                case 4:
                    double ra = getInput("Enter radius");
                    double he = getInput("Enter height");
                    WriteLine("Surface Area: " + calcCylinder(ra, he));
                    break;
            }
            ReadLine();
        }
        public static int getInput(string prompt)
        {
            WriteLine(prompt);
            return int.Parse(ReadLine());
        }
        public static double calcCircle(int r)
        {
            return Math.PI * r * r;
        }
        public static double calcRectangle(int l, int w)
        {
            return l * w;
        }
        public static double calcTrapezoid(double b1, double b2, double h)
        {
            return ((b1 + b2) / 2) * h;
        }
        public static double calcCylinder(double r, double h)
        {
            return (2 * Math.PI * r * h) + (2 * Math.PI * r * r);
        }
    }
}
