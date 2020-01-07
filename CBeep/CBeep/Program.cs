using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CBeep
{
    class Program
    {
        static void Main(string[] args)
        {
            beepclass b = new beepclass();
            b.Beep();
            Console.ReadKey();
            b.MultiBeep(5);
            Console.ReadKey();
            b.SuperBeep(5,5);
            Console.ReadKey();
        }
    }
}
