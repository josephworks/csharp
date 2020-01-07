using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CBeep
{
    class beepclass
    {
        public void Beep()
        {
            System.Console.Beep();
        }

        public void MultiBeep(int count)
        {
            for (int i = 0; i < count; i++)
            {
                System.Threading.Thread.Sleep(100);
                System.Console.Beep();
            }
        }

        public void SuperBeep(int f, int d)
        {
            System.Console.Beep(f, d);
        }
    }
}
