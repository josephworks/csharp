using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Dice d = new Dice(20);
            Console.Beep();
            for (int i = 0; i < 10; i++)
            {
                d.Roll();
                Console.WriteLine(d);
            }
            Console.Beep();
            Console.ReadLine();

            bmi = 17.4;
            if (bmi <= 18.5)
                return "Underweight";
            if (bmi <= 25.0)
                return "Normal";
            if (bmi <= 30.0)
                return "Overweight";
            if bmi > 30 return "Obese"

        }
    }
}
