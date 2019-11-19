using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console; //Allows you tu use "Console." without typing "Console."

namespace HelloConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO:  Street, Zip, Phone, Email
            string first = "";
            string last = "";
            string age = "";
            string street = "";
            string zip = "";
            string phone = "";
            string email = "";
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Beep();
            Console.Clear();
            Console.WriteLine("Console > Hello World!");
            Console.WriteLine("Console > What is your First name?");
            first = ReadLine();
            Console.WriteLine("Console > What is your Last name?");
            last = ReadLine();
            Console.WriteLine("Console > Nice to finally meet you " + last + ", " + first + ".");
            Console.WriteLine("Console > Oh, I forgot to ask, how old are you?");
            age = ReadLine();
            Console.WriteLine("Console > Got it, you are " + age + " years old.");
            Console.WriteLine("Console > What is your street address?");
            street = ReadLine();
            Console.WriteLine("Console > Got it, you are living on / near " + street + ".");
            Console.WriteLine("Console > What is your zip code?");
            zip = ReadLine();
            Console.WriteLine("Console > Got it, you are located in / near " + zip + ".");
            Console.WriteLine("Console > What is your phone number?");
            phone = ReadLine();
            Console.WriteLine("Console > Got it, your phone number is " + phone + ".");
            Console.WriteLine("Console > Last question, What is your email?");
            email = ReadLine();
            Console.WriteLine("Console > Got it, your email is " + email + ".");
            Console.WriteLine("Thanks for the information!");
            Console.WriteLine("Information:");
            Console.WriteLine("Name: " + last + ", " + first);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Street: "  + street);
            Console.WriteLine("ZIP: " + zip);
            Console.WriteLine("Phone Number: " + phone);
            Console.WriteLine("Email: " + email);
            Console.ReadLine();
        }
    }
}
