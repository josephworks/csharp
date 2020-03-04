using System.Activities;
using static System.Console;

namespace WorkflowConsole
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Beep();
            Activity workflow1 = new Workflow1();
            WorkflowInvoker.Invoke(workflow1);
        }
    }
}