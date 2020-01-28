using static System.Console;

namespace InterfacesStuff
{

    class Program
    {
        static void Main(string[] args)
        {
            ICarInterface c = new Car(10, 5, "Car");
            c.setSpeed(60);
            c.drive(60);
            WriteLine(c);
            ReadKey();
        }

        public static void accounts()
        {
            IAccount a = new MyAccount();
            a.deposit(100);
            a.withdraw(50);
            a.withdraw(60);
            WriteLine(a.getBalance().ToString("C2"));
            //WriteLine(Hi(345));
            ReadKey();
        }
        
        
        public static void konami()
        {

            Spaceship s = new Spaceship();

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

            s.Start();

            ReadKey();

        }
    }
}
