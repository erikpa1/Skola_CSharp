using System;
using System.IO;
using System.Collections.Generic;

namespace CatPrikaz
{
    class Program
    {
        private static bool isNumbering;
        private static bool isSearchMode;
        private static string searchText = string.Empty;
        private static List<string> paths = new List<string>();

        static Program()
        {
            Program.isNumbering = false;
        }

        private static void ReadFromFiles()
        {
            foreach (var path in Program.paths)
            {
                var file = "../../../../" + path;

                if (File.Exists(file))
                {
                    var content = File.ReadAllLines(file);

                    for (int i = 0; i < content.Length; i++)
                    {
                        string line = content[i];

                        if (Program.isSearchMode)
                        {
                            if (line.Contains(Program.searchText) == false)
                            {
                                continue;
                            }
                        }

                        if (Program.isNumbering)
                        {
                            Console.Write($"{i+1} \t");
                        }

                        Console.WriteLine(line);

                    }
                }
                else
                {
                    Console.Error.WriteLine("{0} Doexnt exist", path);
                }
            }
        }

        private static void ParseArguments(string[] args)
        {
            for (int i = 0; i < args.Length; i++)
            {
                string argument = (string)args[i];
 
                if (argument == "-n" || argument == "--number")
                {
                    Program.isNumbering = true;
                }
                else if (argument == "--s" || argument == "--search")
                {
                    if (i + 1 < args.Length)
                    {
                        Program.searchText = args[i + 1];
                        Program.isSearchMode = true;
                        i++;
                    }
                }
                else
                {
                    Program.paths.Add(argument);
                }
            }
        }

        static void Main(string[] args)
        {
            foreach (var path in args)
            {
                if (args.Length == 0)
                {
                    do
                    {
                        Console.WriteLine("Write file name");
                        var echoLine = Console.ReadLine();
                        Console.WriteLine(echoLine);
                    } while (true);         
                    
                }
                else
                {
                    ParseArguments(args);
                    ReadFromFiles();
                }
            }
        }
    }
}
