using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Console;

namespace ConsoleForms
{
    class Program
    {
        static void Main(string[] args)
        {
            int times = 0;
            while (times < 10)
            {
                times++;
                if (times == 3)
                    break;
                if (times % 2 == 0)
                    continue;
                Beep(1000, 10000);
            }
        }
    }
}
