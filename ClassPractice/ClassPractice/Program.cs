using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ClassPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Beeper b = new Beeper();
            b.m_duration = 2000;
            b.m_pitch = 500;
            b.superBeep(32000, 32000);
            ReadKey();
        }
    }
}
