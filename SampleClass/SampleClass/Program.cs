using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace SampleClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student(1, 10, "Bob", "Smith");
            s1.setScore1(100);
            s1.setScore2(85);
            s1.setScore3(95);
            WriteLine(s1);
            ReadLine();
        }
    }
}
