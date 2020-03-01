using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace MethodQuiz
{
    class Program
    {
        static void Main(string[] args)
        {
            int ft;
            int inches;
            double m;
            WriteLine("Enter Feet");
            ft = int.Parse(ReadLine());
            WriteLine("Enter Inches");
            inches = int.Parse(ReadLine());
            m = ftTom(ft, inches);
            WriteLine("Meters: {0:N2}", m);
            WriteLine("");

            int l;
            int w;
            int h;
            int sarea;
            WriteLine("Enter Length");
            l = int.Parse(ReadLine());
            WriteLine("Enter Width");
            w = int.Parse(ReadLine());
            WriteLine("Enter Height");
            h = int.Parse(ReadLine());
            sarea = SA(l, w, h);
            WriteLine("Surface Area: " + sarea);
            ReadLine();
        }
        public static double ftTom(int feet, int inches)
        {
            return .0254 * ((feet * 12) + inches);
        }
        public static int SA(int l, int w, int h)
        {
            return 2 * ((w * l) + (h * l) + (h * w));
        }
    }
}
