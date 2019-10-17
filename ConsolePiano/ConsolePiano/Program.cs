using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsolePiano
{
    class Program
    {
        static void Main(string[] args)
        {
            char input = 'a';//define default so the switch case can use it
            bool xa = true;
            while (xa = true)
            {
                //If key is pressed read what it is.
                //Use a while loop to clear extra key presses that may have queued up and only keep the last read
                while (Console.KeyAvailable) input = Console.ReadKey(true).KeyChar;

                //the key read has been converted to a char matching that key
                switch (input)
                {
                    case 'a':
                        Beep(500, 200);
                        break;
                    case 's':
                        Beep(1000, 200);
                        break;
                    case 'd':
                        Beep(2000, 200);
                        break;
                    case 'f':
                        Beep(3000, 200);
                        break;
                    case 'g':
                        Beep(4000, 200);
                        break;
                    case 'h':
                        Beep(5000, 200);
                        break;
                    case 'j':
                        Beep(6000, 200);
                        break;
                    case 'k':
                        Beep(7000, 200);
                        break;
                    case 'l':
                        Beep(8000, 200);
                        break;
                }
            }

        }
    }
}
