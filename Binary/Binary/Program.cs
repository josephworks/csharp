using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Beep();

            Binary b = new Binary(10);

            Console.WriteLine(b);

            Console.ReadLine();
        }
    }
}
