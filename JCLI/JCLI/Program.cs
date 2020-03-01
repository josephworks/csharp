//using CmdLine;
//using CommandLine;
//using System.Net;
//using System.Text;
//using System.Management.Automation;
//using System.Management.Automation.Runspaces;
//using System.Management.Automation.PowerShell;
//using System.Collections.ObjectModel;
using System;
using System.Diagnostics;
using System.IO;
using static System.Console;

namespace JCLI
{
    internal class Program
    {
        //private static void Main(string[] args)
        private static void Main()
        {
            string cmd = "";

            //Original: string path = Directory.GetCurrentDirectory();

            //string path = Directory.GetCurrentDirectory() ?? throw new ArgumentNullException($"Directory.GetCurrentDirectory()");

            //PowerShell ps = PowerShell.Create();
            //ps.AddCommand("Get-Process");
            //ps.AddParameter("Name", "PowerShell - JCLI");
            //ps.Invoke();

            Process process = new Process();
            process.StartInfo.FileName = "powershell.exe";
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.RedirectStandardInput = true;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.UseShellExecute = false;
            process.Start();
            process.StandardInput.WriteLine("version");
            process.StandardInput.Flush();
            process.StandardInput.Close();
            process.WaitForExit();
            Console.WriteLine(process.StandardOutput.ReadToEnd());

            Process process2 = new Process();
            process2.StartInfo.FileName = "cmd.exe";
            process2.StartInfo.CreateNoWindow = true;
            process2.StartInfo.RedirectStandardInput = true;
            process2.StartInfo.RedirectStandardOutput = true;
            process2.StartInfo.UseShellExecute = false;
            process2.Start();
            process2.StandardInput.WriteLine("version");
            process2.StandardInput.Flush();
            process2.StandardInput.Close();
            process2.WaitForExit();
            Console.WriteLine(process2.StandardOutput.ReadToEnd());

            WriteLine("JCLI v2.0 - Copyright JosephWorks 2020");

            while (cmd != null && cmd.ToLower() != "exit")
            {
                Write("JCLI>");
                cmd = ReadLine();
                Process(cmd);
            }
        }

        // static string PowerShellRun(string script)
        // {
        //     Runspace runspace = RunspaceFactory.CreateRunspace();
        //     runspace.Open();
        //     Pipeline pipeline = runspace.CreatePipeline();
        //     pipeline.Commands.AddScript(script);
        //     pipeline.Commands.Add("version"); // PowerShell Command Here
        //     Collection<PSObject> results = pipeline.Invoke();
        //     runspace.Close();
        //     StringBuilder stringBuilder = new StringBuilder();
        //     foreach (PSObject psObject in results)
        //     {
        //         stringBuilder.AppendLine(psObject.ToString());
        //     }
        //     return stringBuilder.ToString();
        // }

        public static void Process(string cmd)
        {
            string[] args = cmd.Split(' ');

            cmd = args[0];

            // if (cmd.Contains(" "))
            // {
            //     args = cmd.Substring(cmd.IndexOf(" ", StringComparison.Ordinal)).Trim();
            //     cmd = cmd.Substring(0, cmd.IndexOf(" ", StringComparison.Ordinal)).Trim();
            // }

            switch (cmd)
            {
                case ("beep"):
                    Beep();
                    break;

                case ("exists"):
                    WriteLine(File.Exists(args[1]));
                    break;

                case ("pwd"):
                    WriteLine(Directory.GetCurrentDirectory());
                    break;

                case ("ls"):
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
                    if (args[1].Length > 0)
                    {
                        if (args[1] == "..")
                        {
                            string cd = Directory.GetParent(Directory.GetCurrentDirectory()).ToString();
                            Directory.SetCurrentDirectory(cd);
                        }
                        else
                        {
                            Directory.SetCurrentDirectory(args[1]);
                        }
                    }
                    break;

                case ("copy"):
                    File.Copy(args[1], args[2]);
                    break;

                case ("rm"):
                case ("del"):
                    File.Delete(args[1]);
                    break;

                case ("rename"):
                case ("ren"):
                    File.Move(args[1], args[2]);
                    break;

                default:
                    WriteLine("Command not found - Passing to PowerShell");
                    Process process = new Process();
                    process.StartInfo.FileName = "powershell.exe";
                    process.StartInfo.CreateNoWindow = true;
                    process.StartInfo.RedirectStandardInput = true;
                    process.StartInfo.RedirectStandardOutput = true;
                    process.StartInfo.UseShellExecute = false;
                    process.Start();
                    process.StandardInput.WriteLine(cmd); // Passes command to powershell
                    process.StandardInput.Flush();
                    process.StandardInput.Close();
                    process.WaitForExit();
                    Console.WriteLine(process.StandardOutput.ReadToEnd());
                    break;
            }
        }
    }
}