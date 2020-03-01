using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace IterationPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Problem1();
            Problem2();
            Problem3();
            Problem4();
            Problem5();
            Problem6();
            Problem7();
            Problem8();
            Problem9();
            Problem10();
            Problem11();
            Problem12();
            ReadLine();
        }
        static void Problem1()
        {
            for (int num = 1; num <= 10; num++)
            {
                Write(num + " ");
            }
            WriteLine();
            WriteLine("");
        }
        static void Problem2()
        {
            WriteLine("The first 10 natural numbers are:");
            for (int num = 1; num <= 10; num++)
            {
                Write(num + " ");
            }
            WriteLine();
            int sum = 0;
            for (int num = 1; num <= 10; num++)
            {
                sum += num;
            }
            WriteLine("Sum: {0}", sum);
            WriteLine("");
        }
        static void Problem3()
        {
            int sum = 0;
            WriteLine("Input the number of terms:");
            int num = int.Parse(ReadLine());
            WriteLine("");
            WriteLine("The first {0} natural numbers are:", num);
            for (int n = 1; n <= num; n++)
            {
                Write(n + " ");
                sum += n;
            }
            WriteLine();
            WriteLine("Sum: {0}", sum);
            WriteLine("");
        }
        static void Problem4()
        {
            {
                int sum = 0;
                int n = 1;
                WriteLine("The first 10 odd natural numbers are:");
                for (int m = 1; m <= 10; n += 2, m++)
                {
                    Write(n + " ");
                    sum += n;
                }
                WriteLine();
                WriteLine("Sum: {0}", sum);
                WriteLine("");
            }
        }
        static void Problem5()
        {
            for (int m = 1; m <= 4; m++)
            {
                for (int n = 1; n <= m; n++)
                {
                    Write(n);
                }
                WriteLine();
            }
            WriteLine("");
        }
        static void Problem6()
        {
            for (int m = 1; m <= 4; m++)
            {
                for (int n = 1; n <= m; n++)
                {
                    Write(m);
                }
                WriteLine();
            }
            WriteLine("");
        }
        static void Problem7()
        {
            int t = 1;
            for (int m = 1; m <= 4; m++)
            {
                for (int n = 1; n <= m; n++, t++)
                {
                    Write(t + " ");
                }
                WriteLine();
            }
            WriteLine("");
        }
        static void Problem8()
        {
            int t = 1;
            for (int m = 1; m <= 3; m++)
            {
                for (int n = 1; n <= m; n++, t += 2)
                {
                    Write(t + " ");
                }
                WriteLine();
            }
            WriteLine("");
        }
        static void Problem9()
        {
            int fac = 1;
            WriteLine("Input the number:");
            int num = int.Parse(ReadLine());
            for (int m = 1; m <= num; m++)
            {
                fac *= m;
            }
            WriteLine("");
            WriteLine("The factorial of {0} is :{1}", num, fac);
            WriteLine("");
        }
        static void Problem10()
        {
            double sum = 0;
            WriteLine("Input the number of terms:");
            int num = int.Parse(ReadLine());
            WriteLine("");
            for (double n = 1; n <= num; n++)
            {
                Write(1 + "/{0} + ", n);
                sum += (1 / n);
            }
            WriteLine();
            WriteLine("Sum of series up to {0} is: {1}", num, sum);
            WriteLine("");
        }
        static void Problem11()
        {
            int sum = 0;
            int m = 0;
            WriteLine("Input the number of terms:");
            int num = int.Parse(ReadLine());
            WriteLine("");
            for (int n = 1; n <= num; n++)
            {
                m = m * 10 + 9;
                Write(m + " ");
                sum += m;
            }
            WriteLine();
            WriteLine("Sum of series up to {0} is: {1}", num, sum);
            WriteLine("");
        }
        static void Problem12()
        {
            int m = 0;
            int p, q;
            WriteLine("Input the number of rows:");
            int num = int.Parse(ReadLine());
            WriteLine("");
            for (int i = 1; i <= num; i++)
            {
                if (i % 2 == 0)
                { p = 1; q = 0; }
                else
                { p = 0; q = 1; }
                for (m = 1; m <= i; m++)
                    if (m % 2 == 0)
                        Write(p);
                    else
                        Write(q);
                WriteLine("");
            }

        }
    }
}
