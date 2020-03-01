using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Spaceship s = new Spaceship();
            /*s.Up();
            s.Up();
            s.Down();
            s.Down();
            s.Left();
            s.Right(); 
            s.Left();
            s.Right();
            s.B();
            s.A();
            s.Start();
            ReadLine(); */
            IAccount a = new MyAccount();
            a.deposit(100);
            a.withdraw(50);
            a.withdraw(60);
            WriteLine(a.getBalance().ToString("C2"));
            ReadLine();
        }
    }
}
