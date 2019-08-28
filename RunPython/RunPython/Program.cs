using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IronPython;
using static System.Console;

namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Microsoft.Scripting.Hosting.ScriptEngine pythonEngine =
                IronPython.Hosting.Python.CreateEngine();
            // We execute this script from Visual Studio 
            // so the program will be executed from bin\Debug or bin\Release
            Microsoft.Scripting.Hosting.ScriptSource pythonScript =
                pythonEngine.CreateScriptSourceFromFile("..\\..\\python.py");
            pythonScript.Execute();
            ReadLine();
        }
    }
}