using System;
using static System.Console;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            WriteLine("Enter a number");
            int.TryParse(ReadLine(), out num1);
            WriteLine("Enter another number");
            int.TryParse(ReadLine(), out num2);
            try
            {
                WriteLine(num1/num2);
            }
            catch (System.DivideByZeroException e)
            {
                Console.Beep();
                WriteLine(e.Message);
            }
            Console.Read();
        }
    }
}
