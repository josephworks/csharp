using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Nov19
{
    class Program
    {
        static void Main(string[] args)
        {
            int weight;
            int height;
            D20 d = new D20();
            for (int i = 0; i < 10; i++)
            {
                d.Roll();
                WriteLine(d);
            }
            ReadLine();
            WriteLine("What is your weight?");
            weight = int.Parse(ReadLine());
            WriteLine("What is your height?");
            height = int.Parse(ReadLine());
        }
        private int BMI(int h, int w)
        {
            return (w / h ^ 2);
        }
    }
}
