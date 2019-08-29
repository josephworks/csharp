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
            //int num;
            //string aValue;
            //Write("Enter number of feet:");
            //aValue = ReadLine();
            //num = int.Parse(aValue);
            //WriteLine(num)

            String name;
            WriteLine("What is your name?");
            name = ReadLine();
            WriteLine("Your Name is {0}", name);
            ReadKey();

            String school;
            WriteLine("What school do you go to?");
            school = ReadLine();
            WriteLine("Your go to {0}", school);
            ReadKey();
            
            String saying;
            WriteLine("What is your favorite saying?");
            saying = ReadLine();
            WriteLine("Your favorite saying is: {0}", saying);
            ReadKey();
        }
    }
}