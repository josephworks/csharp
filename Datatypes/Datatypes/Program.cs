using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Datatypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Beep();
            Console.WriteLine("Maxmum Value: " + int.MaxValue);
            Console.WriteLine("Minimum Value: " + int.MinValue);
            Console.ReadLine();
            byte x = 1;
            sbyte y = 2;
            char z = 3;
            decimal d =9.954758945;
            double b = 22;
            float f = 33;
            int i = 123;
            uint u = 2334;
            long l = 123456789;
            ulong e = 12345678;
            short s = 255;
            ushort h = 12;
            WriteLine(x);
            WriteLine(y);
            WriteLine(z);
            WriteLine(d);
            WriteLine(b);
            WriteLine(f);
            WriteLine(i);
            WriteLine(u);
            WriteLine(l);
            WriteLine(e);
            WriteLine(s);
            WriteLine(h);
            WriteLine("My sallary is: " + "{0:c}"+d,f,1);
            ReadLine();
        }
    }
}
