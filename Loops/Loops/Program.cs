using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Console;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0;
            WriteLine("Enter a number");
            num1 = int.Parse(ReadLine());
            for (int m = 1; m <= num1; m++)
            {
                for (int n = 1; n <= m; n++)
                {
                    Write(m);
                }
                WriteLine();
            }
            ReadLine();
        }
    }
}
