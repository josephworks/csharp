using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Figgle;

namespace ASCIIText
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(
                FiggleFonts.Standard.Render("Hello, World!"));
            Console.ReadLine();
        }
    }
}
