using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace MoreMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Print("Richard", "Bob", "Jones" + "\n");
            WriteLine(CylinderVolume(1, 2) + "\n");
            CalcChange(1.74);
            WriteLine(GetHype(3, 4) + "\n");
            WriteLine(DtoE(50));
            ReadLine();
        }

        public static void Print(string first, string middle, string last)
        {
            WriteLine("First: " + first);
            WriteLine("Middle: " + middle);
            WriteLine("Last: " + last);
        }
        public static double CylinderVolume(double radius, double height)
        {
            return Math.PI * radius * radius * height;
        }
        public static void CalcChange(double amt)
        {
            int amount = (int)(amt * 100);
            int dollars;
            int quarters;
            int dimes;
            int nickels;
            int pennies;
            dollars = amount / 100;
            amount %= 100;
            quarters = amount / 25;
            amount %= 25;
            dimes = amount / 10;
            amount %= 10;
            nickels = amount / 5;
            amount %= 5;
            pennies = amount;
            WriteLine("Dollars: " + dollars);
            WriteLine("Quarters: " + quarters);
            WriteLine("Dimes: " + dimes);
            WriteLine("Nickels: " + nickels);
            WriteLine("Pennies: " + pennies + "\n");
        }
        public static double GetHype(double a, double b)
        {
            double hyp2 = (a * a) + (b * b);
            return Math.Sqrt(hyp2);
        }
        public static double DtoE(double d)
        {
            return d * .97;
        }
    }
}
