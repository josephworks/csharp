using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Tuesday
{
    class Program
    {
        static void Main(string[] args)
        {
            int answer = square(7);
            WriteLine("The square of 7 is {0}", answer);
            ReadLine();
        }
        private static int square(int num)
        {
            return num * num;
        }
    }
}
