using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Beep(); //Most important

            //int num;
            //string aValue;
            //Write("Enter number of feet:");
            //aValue = ReadLine();
            //num = int.Parse(aValue);
            //WriteLine();

            //Todo > Convert to methods

            ForegroundColor = ConsoleColor.Green;

            String name;
            WriteLine("What is your name?");
            name = ReadLine();
            WriteLine("Your Name is {0}", name);
            WriteLine("");

            String saying;
            WriteLine("What is your favorite saying?");
            saying = ReadLine();
            WriteLine("Your favorite saying is: {0}", saying);
            ReadKey();

            String school;
            WriteLine("What school do you go to?");
            school = ReadLine();
            WriteLine("You go to {0}", school);
            ReadKey();

            String output;
            WriteLine("{0} - {1} {2}", saying, name, school);
        }

        public static string student(string name)
        {
            return name;
        }
    }
}