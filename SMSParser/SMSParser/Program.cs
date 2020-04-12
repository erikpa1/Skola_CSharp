using System;
using System.IO;
using SMSParser;

namespace SMSParser
{
    class Program
    {
        static bool inputModeActive = false;
        static String inputFile = "";

        static bool outputModeActive = false;
        static String outPutFile = "";

        static SMSParser parser = null;

        static void Main(string[] args)
        {
            parser = new SMSParser();


            if (args.Length == 0)
            {
                ReadFromUser();
            }
            else if (args.Length == 1)
            {
                Console.WriteLine(parser.Parse(args[0]));
            }
            else
            {
                ParseArguments(args);

                if (inputModeActive == true)
                {
                    if (inputFile != String.Empty)
                    {
                        if (File.Exists(inputFile))
                        {
                            var fileContent = File.ReadAllText(inputFile);

                            var parsedText = parser.Parse(fileContent);

                            if (outputModeActive == true)
                            {
                                if (outPutFile == String.Empty)
                                {
                                    Console.WriteLine("Output file is empty, ending app.");
                                }
                                else
                                {
                                    Console.WriteLine("Folder created");
                                    var file = File.CreateText(outPutFile);

                                    file.WriteLine(parsedText);
                                    file.Close();

                                }
                            }
                            else
                            {
                                Console.WriteLine("Writing to standard because output mode is off");
                                Console.WriteLine(parsedText);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Input file does not exists");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Input file path is empty, ending app.");
                    }
                }
                else
                {
                    Console.WriteLine("There is no input mode active");
                }
            }

            Console.WriteLine("App End");
        }

        static void ParseArguments(string[] arguments)
        {
            Console.Write("Parsing arguments: ");

            foreach (var i in arguments)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("");

            for (int i = 0; i < arguments.Length; i++)
            {
                var argument = arguments[i];

                if (argument == "-i" || argument == "--input")
                {
                    inputModeActive = true;
                    if (arguments.Length >= i + 1)
                    {
                        inputFile = "../../../../" + arguments[i + 1];
                        Console.WriteLine("Input file: " + inputFile);
                        i++;
                    }
                }

                if (argument == "-o" || argument == "--output")
                {
                    outputModeActive = true;

                    if (arguments.Length >= i + 1)
                    {
                        outPutFile = "../../../../" + arguments[i + 1];
                        Console.WriteLine("Output file: " + inputFile);
                        i++;
                    }
                }
            }
        }

        static void ReadFromUser()
        {
            Console.WriteLine("Enter the string for parsing, for leave enter empty line");

            var userInput = Console.ReadLine();

            if (userInput == String.Empty)
            {
                if (AskExitQuestion())
                {
                    return;
                }
                else
                {
                    ReadFromUser();
                }
            }
            else
            {
                Console.WriteLine(parser.Parse(userInput));
                ReadFromUser();
            }

        }

        static bool AskExitQuestion()
        {
            Console.WriteLine("Wanna leave? Type y/yes for leave or n/no for staying here");

            var input = Console.ReadLine();

            if (input == "y" || input == "yes")
            {
                return true;
            }
            else if (input == "n" || input == "no")
            {
                return false;
            }
            else
            {
                return AskExitQuestion();
            }

            return false;
        }

    }

}
