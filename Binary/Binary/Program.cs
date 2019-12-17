using System;
using static System.Console;

namespace Binary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Beep();
            Binary b = new Binary(10);
            WriteLine(b);
            ReadLine();
        }
    }
}
