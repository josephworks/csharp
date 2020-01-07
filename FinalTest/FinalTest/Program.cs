using System;
using System.Diagnostics;
using static System.Console;

namespace FinalTest
{
    internal class Program
    {
        private static void Main(string[] args)
        {
        private int[,] a1 = { { 1, 1 }, { 1, 1 } };

        private int[,] a2 = { { 1, 1 }, { 1, 1 } };

        private Matrix m = new Matrix(a1);
        private Matrix m2 = new Matrix(a2);

        WriteLine(m);

        WriteLine(" + ");

        WriteLine(m2);

        WriteLine(" + ");
        WriteLine(Matrix.2);
    }
}
}