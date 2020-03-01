using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Feb12
{
    class Program
    {
        static void Main(string[] args)
        {
            string cmd = "";
            while (cmd.ToLower() != "exit")
            {
                Write("<");
                cmd = ReadLine();
                Process(cmd);
            }
        }
        public static void Process(string cmd)
        {
            string[] args = cmd.Split(' ');
            cmd = args[0];
            switch (cmd.ToLower())
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
                    if (args.Length > 0)
                    {
                        if (args[1] == "..")
                        {
                            Directory.SetCurrentDirectory(Directory.GetCurrentDirectory().ToString());
                        }
                    }
                    Directory.SetCurrentDirectory(args[1]);
                    break;
                case ("copy"):
                    File.Copy(args[1], args[2]);
                    break;
                case ("del"):
                    File.Delete(args[1]);
                        break;
                case ("ren"):
                    File.Move(args[1], args[2]);
                    break;
                case ("fileinfo"):
                    FileInfo fi = new FileInfo(args[1]);
                    WriteLine(fi.Length + " " + fi.LastWriteTime + " " + fi.CreationTime + " " + fi.IsReadOnly);
                    break;
                default:
                    WriteLine("Command not found");
                    break;
            }
        }
    }
}
