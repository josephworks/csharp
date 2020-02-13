using System;
using System.IO;
//using CmdLine;
//using CommandLine;
using System.Management;
//using System.Management.Automation.Powershell;
using static System.Console;

//TODO!
////TODO: Port to .Net core ASAP!!!
//TODO!

namespace ConsoleCLI
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string cmd = "";

            string path = Directory.GetCurrentDirectory();

            //PowerShell ps = PowerShell.Create();

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
                args = cmd.Substring(cmd.IndexOf(" ", StringComparison.Ordinal)).Trim();
                cmd = cmd.Substring(0, cmd.IndexOf(" ", StringComparison.Ordinal)).Trim();
            }

            switch (cmd)
            {
                case ("beep"):
                    Beep();
                    break;

                case ("exists"):
                    WriteLine(File.Exists(args));
                    break;

                case ("pwd"):
                    WriteLine(Directory.GetCurrentDirectory());
                    break;

                case ("ls"):
                    WriteLine(Directory.GetFiles(Directory.GetCurrentDirectory()));
                    break;

                case ("dir"):
                    foreach (string d in Directory.GetDirectories(Directory.GetCurrentDirectory()))
                    {
                        WriteLine(d + "\\");
                    }
                    foreach (string f in Directory.GetFiles(Directory.GetCurrentDirectory()))
                    {
                        WriteLine(f);
                    }
                    break;

                case ("cd"):
                    if (args.Length > 0)
                    {
                        if (args == "..")
                        {
                            string cd = Directory.GetParent(Directory.GetCurrentDirectory()).ToString();
                            Directory.SetCurrentDirectory(cd);
                        }
                        else
                        {
                            Directory.SetCurrentDirectory(args);
                        }
                    }
                    break;

                default:
                    WriteLine("Command not found");
                    //Powershell.Create("get-process").Invoke();
                    break;
            }
        }
    }
}