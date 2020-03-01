using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace MethodPrac
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine(Convert(GetSeconds()));
            ReadLine();
        }
        //get seconds
        public static int GetSeconds()
        {
            WriteLine("Enter seconds:");
            return int.Parse(ReadLine());
        }
        //convert
        public static string Convert(int seconds)
        {
            int hours = seconds / 3600;
            int minutes = (seconds % 3600) / 60;
            int sec = seconds % 60;
            return hours + " hours, " + minutes + " minutes, and " + sec + " seconds";
        }
        //output results
    }
}

