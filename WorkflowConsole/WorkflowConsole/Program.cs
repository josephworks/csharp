using System;
using System.Linq;
using System.Activities;
using System.Activities.Statements;
using static System.Console;

namespace WorkflowConsole
{

    class Program
    {
        static void Main(string[] args)
        {
            Beep();
            Activity workflow1 = new Workflow1();
            WorkflowInvoker.Invoke(workflow1);
        }
    }
}
