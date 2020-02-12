using System;
//using CmdLine;
//using CommandLine;
using static System.Console;

namespace ConsoleCLI
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string cmd = "";

            WriteLine("JCLI v1.0 - Copyright JosephWorks 2020");

            while (cmd != null && cmd.ToLower() != "exit")
            {
                Write("JCLI>");
                cmd = ReadLine();
                Process(cmd);
            }
        }

        public static void Process(string cmd)
        {
            String args = "";

            if (cmd.Contains(" "))
            {
                args = cmd.Substring(cmd.IndexOf(" ", StringComparison.Ordinal));
                cmd = cmd.Substring(0, cmd.IndexOf(" ", StringComparison.Ordinal));
            }

            switch (cmd)
            {
                case ("beep"):
                    Beep();
                    break;

                case ("exists"):
                    Write("Blank Text");
                    break;

                default:
                    WriteLine("Command not found");
                    break;
            }
        }
    }
}