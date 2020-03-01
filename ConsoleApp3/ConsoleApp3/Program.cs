using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;
            int size;
            WriteLine("How many numbers?");
            size = int.Parse(ReadLine());
            double[] myDoubles = new double[size];
            for (int i = 0; i < myDoubles.Length; i++)
            {
                WriteLine("Enter a number.");
                myDoubles[i] = double.Parse(ReadLine());
            }
            foreach (double item in myDoubles)
            {
                sum += item;
            }
            WriteLine("The average is {0:N2}", sum/size);
            ReadLine();
        }
    }
}
            /* int[] myInts = new int[100];
            for (int i = 1; i <= 100; i++)
            {
                myInts[i - 1] = i;
            }
            for (int i = 0; i < myInts.Length; i++)
            {
                myInts[i] = 7;
            }
            foreach (int item in myInts)
            {
                WriteLine(item);
            }
            string[] myStrings = {"bob", "sue", "joe"};
            foreach (string item in myStrings)
            {
                WriteLine(item);
            }*/
