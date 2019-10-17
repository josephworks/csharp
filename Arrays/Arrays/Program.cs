using System;
using static System.Console;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Beep(1000, 100);
            double[] myDoubles = new double[10];
            //int size = 0;
            double sum = 0;
            //WriteLine("Amount of numbers: ");
            //size = int.Parse(ReadLine());
            for (int i = 0; i < myDoubles.Length; i++)
            {
                myDoubles[i] = Double.Parse(ReadLine());
            }

            foreach (double item in myDoubles)
            {
                sum = sum + item;
            }
            ReadLine();
            /*Console.Beep();
            double[] myDoubles = new double[10];
            int[] myInts = new int[1000000];
            for (int i = 1; i <= 1000000; i++)
            {
                myInts[i - 1] = i;
            }

            for (int i = 0; i < myInts.Length; i++)
            {
                //myInts[i] = 7;
            }

            foreach (int item in myInts)
            {
                WriteLine(item);
            }

            Console.Beep();
            ReadLine();*/
        }
    }
}
