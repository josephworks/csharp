using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleFramework
{
    public class FunctionsClass
    {
        int counter = 0;
        // Add two numbers
        public int AddTwo(int a, int b)
        {
            return a + b;
        }

        // Find smallest of two numbers
        public int MinTwo(int a, int b)
        {
            if (a < b)
                return a;
            else
                return b;
        }

        // Find average of three numbers
        public int AvgThree(int a, int b, int c)
        {
            return (a + b + c) / 3;
        }

        // Find the sum of the nth and kth number in an array
        public int SumTwo(int[] array, int n, int k)
        {
            return array[n] + array[k];
        }

        // Find the sum of the nth through kth numbers in an array
        public int SumRange(int[] array, int n, int k)
        {
            int sum = 0;
            for (int i = n; i <= k; i++)
            {
                sum += array[n];
            }
            return sum;
        }

        // Reset our counter
        public void Reset()
        {
            counter = 0;
        }
        // Add n to our internal counter
        public void Increase(int n)
        {
            counter += n;
        }

        // Decrease our internal counter by n
        public void Decrease(int n)
        {
            counter -= n;
        }

        // Get the value of the counter
        public int GetValue()
        {
            return counter;
        }


    }
}
