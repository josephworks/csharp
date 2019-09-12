using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using IronPython;
using static System.Console;

namespace GoogleAssistant
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
            Console.Beep(); //Plays Beep before running python
            pythonScript.Execute();
            ReadLine();
        }
    }
}