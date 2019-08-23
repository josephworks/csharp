using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace FormatOutput
{
    class Program
    {
        static void Main(string[] args)
        {
            Beep(); //Honestly, This is VERRY IMPORTNT
            const double miles = 4.5;
            WriteLine(miles);
            ReadLine();
            WriteLine("{0:N2}", miles);
            ReadLine();
            WriteLine("Converting to Feet and Inches...");
            WriteLine("Feet: " + miles * 5280);
            WriteLine("Inches: " + miles * 63360);
            ReadLine();
            
        }
    }
}
