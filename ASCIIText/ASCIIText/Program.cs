using System;
using Figgle;

namespace ASCIIText
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(
                FiggleFonts.Slant.Render("Hello, World!"));
            Console.WriteLine(
                FiggleFonts.Standard.Render("Hello, World!"));
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine(@".--------------.
|      /~~\    |
|   W ( %% )   |
|    \ \--/    |
|      \II     |
|       <>\    |
|       <>  \  |
|       <>   M |
|      /  \    |
|     /    \   |
`--------------'");
            Console.WriteLine(@"    J RRRR  
    J R   R 
    J RRRR  
J   J R R   
 JJJ  R  RR ");
            Console.WriteLine(@"+------------------+             XXXXXXXXXXXXX                     XX
|                  |           XXX            XX                   X XX
|                  |           X                X                 XX  XX
|                  |          X                 X                XX    XX
|                  |          X                 X                X      XX
|                  |          XX                X               X        XXX
|                  |           XX              XX              XX          XX
|                  |            X             XX               X            XXX
|                  |             XX         XX                X               XX
|                  |              XX      XXX                XX                XX
+------------------+               XXX XXXX                 XX                   XX
                                                            XXXXXXXXXXXXXXXXXXXXXXX

");
            Console.ReadLine();
        }
    }
}
