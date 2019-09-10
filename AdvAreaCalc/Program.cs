using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace AdvAreaCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("The area of a circle - 1, the area of a rectangle - 2, the area of a trapezoid - 3, or the surface area of a cylinder - 4");
            int input = int.Parse(ReadLine());
            switch (input)
            {
                case 1:
                    WriteLine("Circle");
                    WriteLine("What is the radius?");
                    double radius = double.Parse(ReadLine());
                    double circle = (Math.PI * (radius * radius));
                    WriteLine(circle);
                    ReadLine();
                    break;
                case 2:
                    WriteLine("Rectangle");
                    WriteLine("What is the length?");
                    double rectanglearea = double.Parse(ReadLine());
                    WriteLine("What is the width?");
                    double rectanglelength = double.Parse(ReadLine());
                    double rectangle = (rectanglearea * rectanglelength);
                    WriteLine(rectangle);
                    ReadLine();
                    break;
                case 3:
                    WriteLine("Trapezoid");
                    WriteLine("What is the base?");
                    double trapezoidbase1 = double.Parse(ReadLine());
                    WriteLine("What is the other base?");
                    double trapezoidbase2 = double.Parse(ReadLine());
                    WriteLine("What is the height?");
                    double trapezoidheight = double.Parse(ReadLine());
                    double trapezoid = ((trapezoidbase1 + trapezoidbase2) / 2 * trapezoidheight);
                    WriteLine(trapezoid);
                    ReadLine();
                    break;
                case 4:
                    WriteLine("Cylinder");
                    WriteLine("What is the radius?");
                    double cylinderradius = double.Parse(ReadLine());
                    WriteLine("What is the height?");
                    double cylinderheight = double.Parse(ReadLine());
                    double cylinder = (2 * Math.PI * cylinderradius * cylinderheight) + (2 * Math.PI * (cylinderradius * cylinderradius));
                    WriteLine(cylinder);
                    ReadLine();
                    break;
            }
        }
    }
}
