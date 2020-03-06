using System;
using System.IO;
using SMSParser;

namespace SMSParser
{
    class Program
    {
        static String inputFile = "";
        static String outPutFile = "";

        static void Main(string[] args)
        {
            SMSParser parser = new SMSParser();


            if (args.Length == 0)
            {
                Console.WriteLine("Ending because of no argument");
                return;
            }
            else if (args.Length == 1)
            {
                Console.WriteLine(parser.Parse(args[0]));
            }
            else
            {
                ParseArguments(args);

                if (Program.inputFile != String.Empty)
                {
                    if (File.Exists(Program.inputFile))
                    {
                        var fileContent = File.ReadAllText(Program.inputFile);

                        Console.WriteLine();
                    }
                }



            }


            Console.WriteLine("App End");
        }

        static void ParseArguments(string[] arguments)
        {
            for (int i = 0; i < arguments.Length; i++)
            {
                var argument = arguments[i];

                if (argument == "-i" || argument == "--input")
                {
                    if (argument.Length > i + 1)
                    {
                        Program.inputFile = arguments[i + 1];
                        i++;
                    }
                }
                else if (argument == "-o" || argument == "--output")
                {
                    if (argument.Length > i + 1)
                    {
                        Program.outPutFile = arguments[i + 1];
                        i++;
                    }
                }
            }
        }

    }

}
