using System;
using static System.Console;

namespace Iteration
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            {
                Console.Beep(1500,100);
                Console.Beep(1500,100);
                Console.ForegroundColor = ConsoleColor.Green;
                Problem1();
                WriteLine("Press ENTER to continue...");
                ReadLine();
                Console.Clear();
                Problem2();
                WriteLine("Press ENTER to continue...");
                ReadLine();
                Console.Clear();
                Problem3();
                WriteLine("Press ENTER to continue...");
                ReadLine();
                Console.Clear();
                Problem4();
                WriteLine("Press ENTER to continue...");
                ReadLine();
                Console.Clear();
                Problem5();
                WriteLine("Press ENTER to continue...");
                ReadLine();
                Console.Clear();
                Problem6();
                WriteLine("Press ENTER to continue...");
                ReadLine();
                Console.Clear();
                Problem7();
                WriteLine("Press ENTER to continue...");
                ReadLine();
                Console.Clear();
                Problem8();
                WriteLine("Press ENTER to continue...");
                ReadLine();
                Console.Clear();
                Problem9();
                WriteLine("Press ENTER to continue...");
                ReadLine();
                Console.Clear();
                Problem10();
                WriteLine("Press ENTER to continue...");
                ReadLine();
                Console.Clear();
                Problem11();
                WriteLine("Press ENTER to continue...");
                ReadLine();
                Console.Clear();
                Problem12();
                WriteLine("Press ENTER to continue...");
                ReadLine();
            }

            static void Problem1()
            {
                for (int number = 1; number <= 10; number++)
                {
                    Write(number + " ");
                }

                WriteLine();
                WriteLine("");
            }

            static void Problem2()
            {
                WriteLine("The first 10 natural numbers are:");
                for (int number = 1; number <= 10; number++)
                {
                    Write(number + " ");
                }

                WriteLine();
                int sum = 0;
                for (int number = 1; number <= 10; number++)
                {
                    sum += number;
                }

                WriteLine("Sum: {0}", sum);
                WriteLine("");
            }

            static void Problem3()
            {
                int sum = 0;
                WriteLine("Input the number of terms:");
                int number = int.Parse(ReadLine());
                WriteLine("");
                WriteLine("The first {0} natural numbers are:", number);
                for (int n = 1; n <= number; n++)
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
                int number = int.Parse(ReadLine());
                for (int m = 1; m <= number; m++)
                {
                    fac *= m;
                }

                WriteLine("");
                WriteLine("The factorial of {0} is :{1}", number, fac);
                WriteLine("");
            }

            static void Problem10()
            {
                double sum = 0;
                WriteLine("Input the number of terms:");
                int number = int.Parse(ReadLine());
                WriteLine("");
                for (double n = 1; n <= number; n++)
                {
                    Write(1 + "/{0} + ", n);
                    sum += (1 / n);
                }

                WriteLine();
                WriteLine("Sum of series up to {0} is: {1}", number, sum);
                WriteLine("");
            }

            static void Problem11()
            {
                int sum = 0;
                int m = 0;
                WriteLine("Input the number of terms:");
                int number = int.Parse(ReadLine());
                WriteLine("");
                for (int n = 1; n <= number; n++)
                {
                    m = m * 10 + 9;
                    Write(m + " ");
                    sum += m;
                }

                WriteLine();
                WriteLine("Sum of series up to {0} is: {1}", number, sum);
                WriteLine("");
            }

            static void Problem12()
            {
                int p, q;
                WriteLine("Input the number of rows:");
                int number = int.Parse(ReadLine());
                WriteLine("");
                for (int i = 1; i <= number; i++)
                {
                    if (i % 2 == 0)
                    {
                        p = 1;
                        q = 0;
                    }
                    else
                    {
                        p = 0;
                        q = 1;
                    }

                    int m;
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
}