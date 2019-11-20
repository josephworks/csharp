using static System.Console;

namespace Exponent
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Beep();
            for (int i = 0; i < 64; i++)
            {
                num = i ^ 2;
                WriteLine(num);
            }
            ReadLine();
        }
    }
}
