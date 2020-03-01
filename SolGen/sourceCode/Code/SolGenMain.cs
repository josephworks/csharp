#region Copyright MIT License
/*
 * Copyright © 2008 François St-Arnaud and John Wood
 * 
 * Permission is hereby granted, free of charge, to any person
 * obtaining a copy of this software and associated documentation
 * files (the "Software"), to deal in the Software without
 * restriction, including without limitation the rights to use,
 * copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the
 * Software is furnished to do so, subject to the following
 * conditions:
 * 
 * The above copyright notice and this permission notice shall be
 * included in all copies or substantial portions of the Software.
 * 
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
 * EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
 * OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
 * NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
 * HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
 * WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
 * FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
 * OTHER DEALINGS IN THE SOFTWARE.
 *
 * SolGen, Visual Studio Solution Generator for C# Projects (http://codeproject.com/SolGen)
 * Based on original work by John Wood developer of Priorganizer (http://www.priorganizer.com)
 * Adapted for Visual Studio 2005 by François St-Arnaud (francois.starnaud@videotron.ca)
 * Published to CodePlex with original author's permission.
 * 
 * Original software copyright notice:
 * © Copyright 2005 J. Wood Software Services. All rights reserved.
 * You are free to modify this source code at will, but please give credit to John Wood
 * if decide to incorporate or redistribute the resultant binary.
 * http://www.servicestuff.com/jwss/page.aspx?page=utility.htm&utility=solgen
 * 
 */
#endregion

using System;

namespace SolGen
{
    /// <summary>
    /// A utility for fixing project references and generating solution files.
    /// </summary>
    internal class SolGenMain
    {
        private static void Main(string[] args)
        {
            try
            {
                new SolutionGenerator().Start(args);
            }
            catch (Exception e)
            {
                Console.WriteLine();
                Console.WriteLine("A problem occurred running SolGen and the generation did not complete.");
                Console.WriteLine("Exception: " + e.Message + " (" + e.GetType().Name + ")");
                Console.WriteLine(e.StackTrace);
            }
#if DEBUG
            Console.ReadKey();
#endif
        }
    }
}
