using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ForConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Beep(1000, 100);
            int num = 0;
            WriteLine("Enter a number");
            num = int.Parse(ReadLine());
            for (int r = 1; r <= num; r++)
            {
                for (int c = 1; c <= num; c++)
                {
                    Write("*" + "\t");
                }
                WriteLine();
            }
            ReadLine();
        }
    }
}
