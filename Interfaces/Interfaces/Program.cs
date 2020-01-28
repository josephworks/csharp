using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            SpaceShip s = new SpaceShip();

            s.Up();
            s.Up();

            s.Down();
            s.Down();

            s.Left();

            s.Right();

            s.Left();

            s.Right();

            s.B();

            s.A();

            s.B();

            s.A();

            s.Start();

        }
    }
}
