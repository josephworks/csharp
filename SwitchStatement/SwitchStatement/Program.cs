using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace SwitchStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            int weekDay = 1;
            switch(weekDay)
            {
                case 1: WriteLine("Monday");
                    break;
                case 2: WriteLine("Tuesday");
                    break;
                case 3: WriteLine("Wednesday");
                    break;
                case 4: WriteLine("Thursday");
                    break;
                case 5: WriteLine("Friday");
                    break;
                default: WriteLine("Not Monday - Friday");
                    break;
            }
        }
    }
}
