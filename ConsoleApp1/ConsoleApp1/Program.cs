using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1;
            double num2;
            string aValue;
            string bValue;
            Write("Enter miles: ");
            aValue = ReadLine();
            num1 = double.Parse(aValue);
            WriteLine("{0} miles in feet is {1}", num1, miles(num1));
            WriteLine("");
            Write("Enter dollars: ");
            aValue = ReadLine();
            num1 = double.Parse(aValue);
            WriteLine("{0:C2} dollars in euros is {1:C2}", num1, dollars(num1));
            WriteLine("");
            Write("Enter length: ");
            aValue = ReadLine();
            Write("Enter width: ");
            bValue = ReadLine();
            num1 = double.Parse(aValue);
            num2 = double.Parse(bValue);
            WriteLine("A rectangle with a length of {0} and a width of {1} has an area of {2}", num1, num2, rectanglearea(num1, num2));
            ReadLine();
        }
        public static double miles(double feet)
        {
            return feet * 5280;
        }
        public static double dollars(double euros)
        {
            return euros * .9;
        }
        public static double rectanglearea(double length, double width)
        {
            return length * width;
        }
    }
}
