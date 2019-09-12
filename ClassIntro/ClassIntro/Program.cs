using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Beep();
            Point p1 = new Point(1, 1);
            Point p2 = new Point(2, 2);
            WriteLine(p1);
            WriteLine(p2);
            Line l1 = new Line(p1, p2);
            ReadLine();
        }
    }
}
