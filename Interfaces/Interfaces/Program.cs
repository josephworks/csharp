using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            SpaceShip s = new SpaceShip();

            //Console.Beep(2000, 3000);

            s.Up();
            s.Up();

            s.Down();
            s.Down();

            s.Left();

            s.Right();

            s.A();

            s.B();
        }
    }
}
