using System.IO;
using static System.Console;

namespace ConsoleCLI
{
    internal class Program
    {
        //private static void Main(string[] args)
        private static void Main()
        {
            string cmd = "";

            //Original: string path = Directory.GetCurrentDirectory();

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

                case ("fileinfo"):
                    FileInfo fi = new FileInfo(args[1]);
                    WriteLine("Length: " + fi.Length);
                    WriteLine("Creation Time: " + fi.CreationTime);
                    WriteLine("Last Access Time: " + fi.LastAccessTime);
                    WriteLine("Last Save: " + fi.LastWriteTime);
                    WriteLine("Is Read Only: " + fi.IsReadOnly);
                    break;
                default:
                    WriteLine("Command not found");
                    break;
            }
        }
    }
}