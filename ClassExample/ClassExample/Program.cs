using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ClassExample
{
    class Program
    {
        static void Main(string[] args)
        {
            ForegroundColor = ConsoleColor.Green;
            Beep();
            Student s1 = new Student(1, 10, 100, 100, 100, "Joseph", "Robinson");
            s1.setScore1(85);
            s1.setScore2(90);
            s1.setScore3(95);
            WriteLine(s1);
            ReadLine();
        }
    }
}
