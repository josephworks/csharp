using System;
using System.Threading;
using static System.Console;

namespace CBeep
{
    class Beepclass
    {
        public void Beep()
        {
            Console.Beep();
        }

        public void MultiBeep(int count)
        {
            for (int i = 0; i < count; i++)
            {
                Thread.Sleep(100);
                Console.Beep();
            }
        }

        public void SuperBeep(int f, int d)
        {
            Console.Beep(f, d);
        }
    }
}
