using System;

namespace Interfaces
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            SpaceShip s = new SpaceShip();

            //Console.Beep(2000, 3000);

            //s.Up();
            //s.Up();

            //s.Down();
            //s.Down();

            //s.Left();

            //s.Right();

            //s.A();

            //s.B();

            IAccount a = new MyAccount();
            Console.WriteLine(a.GetBalance());
            a.Deposit(100);
            Console.WriteLine(a.GetBalance());
            a.Withdraw(50);
            Console.WriteLine(a.GetBalance());
            a.Withdraw(60);
            Console.WriteLine(a.GetBalance());
            Console.ReadLine();
        }
    }
}