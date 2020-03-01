using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Final
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] a1 = { { 1, 1 }, { 1, 1 } };
            int[,] a2 = { { 1, 2 }, { 3, 4 } };

            Matrix m = new Matrix(a1);
            Matrix m2 = new Matrix(a2);

            WriteLine(m);
            WriteLine(" + ");
            WriteLine(m2);
            WriteLine(" = ");
            WriteLine(m.add(m2));
            WriteLine();

            WriteLine(2);
            WriteLine(" * ");
            WriteLine(m2);
            WriteLine(" = ");
            WriteLine(m2.scalarMultiply(2));
            ReadKey();
        }
    }
}
