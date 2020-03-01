using System;
using static System.Console;

namespace Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            string quote;
            double length;
            double width;
            double area;
            double perimeter;

            name = GetInput("Enter your name: ");
            quote = GetInput("Enter your favorite saying: ");
            OutputName(name, quote);
            Asterisk();
            SchoolInfo();
            Asterisk();
            WriteLine("");
            length = GetInputNum("Enter Length");
            width = GetInputNum("Enter Width");
            area = Area(length, width);
            perimeter = Perimeter(length, width);
            OutputRectangle(area, perimeter);
            ReadLine();
        }
        public static string GetInput(string prompt)
        {
            WriteLine(prompt);
            return ReadLine();
        }
        public static void OutputName(string fullname, string saying)
        {
            WriteLine("");
            WriteLine("<><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><>");
            WriteLine("Your name is {0} and your favorite saying is {1}", fullname, saying);
            WriteLine("<><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><>");
            WriteLine("");
        }
        public static void Asterisk()
        {
            WriteLine("*********************************************************************");
        }
        public static void SchoolInfo()
        {
            WriteLine("School Name: Boulder Creek");
            WriteLine("School Colors: Red and Black");
            WriteLine("Students Enrolled: 4356");
            WriteLine("Start Time: 7:30");
        }
        public static double GetInputNum(string prompt)
        {
            WriteLine(prompt);
            return double.Parse(ReadLine() ?? throw new InvalidOperationException());
        }
        public static double Area(double l, double w)
        {
            return l * w;
        }
        public static double Perimeter(double l, double w)
        {
            return (2 * l) + (2 * w);
        }
        public static void OutputRectangle(double a, double p)
        {
            WriteLine("");
            WriteLine("Area:      {0:N1}" , a);
            WriteLine("Perimeter: {0:N1}", p);
            WriteLine("");
        }
    }
}
