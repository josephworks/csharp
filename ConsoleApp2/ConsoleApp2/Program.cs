using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int meal;
            WriteLine("What would you like to eat?");
            WriteLine("Type 1 for Breakfast, 2 for Lunch, 3 for Dinner");
            meal = int.Parse(ReadLine());
            switch (meal)
            {
                case 1:
                    WriteLine("You chose breakfast");
                    break;
                case 2:
                    WriteLine("You chose lunch");
                    break;
                case 3:
                    WriteLine("You chose dinner");
                    break;
                default:
                    WriteLine("Please pick a valid");
                    break;
            }
            ReadLine();
        }
    }
}
