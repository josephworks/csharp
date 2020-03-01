using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ClassesIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(1, 1);
            Point p2 = new Point(4, 5);
            Line l = new Line(p1, p2);
            WriteLine(l);
            ReadLine();
        }
    }
}
