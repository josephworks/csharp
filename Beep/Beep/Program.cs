using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AudioSwitcher;
using AudioSwitcher.AudioApi;
using AudioSwitcher.AudioApi.CoreAudio;
using static System.Console;

namespace Beep
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Beep();
                Console.WriteLine("Hello World!");
                ReadLine();
            }
        }
    }
}
