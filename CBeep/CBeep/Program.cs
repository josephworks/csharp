using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CBeep
{
    class Program
    {
        static void Main(string[] args)
        {
            Beepclass b = new Beepclass();
            b.Beep();
            ReadKey();
            b.MultiBeep(5);
            ReadKey();
            b.SuperBeep(2500,5);
            ReadKey();
        }
    }
}
