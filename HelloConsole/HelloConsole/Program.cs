using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console; //Allows you tu use "Console." without typing "Console."

namespace HelloConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            string first = "";
            string last = "";
            string age = "";
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Beep();
            Console.Clear();
            Console.WriteLine("Console > Hello World!");
            Console.WriteLine("Console > What is your First name?");
            first = ReadLine();
            Console.WriteLine("Console > What is your Last name?");
            last = ReadLine();
            Console.WriteLine("Console > Nice to finally meet you " + last + ", " + first);
            Console.WriteLine("Console > Oh, I forgot to ask, how old are you?");
            age = ReadLine();
            Console.WriteLine("Console > Got it, you are " + age + " years old");
            Console.ReadLine();
        }
    }
}
