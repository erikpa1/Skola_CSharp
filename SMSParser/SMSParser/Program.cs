using System;

using SMSParser;

namespace SMSParser
{
    class Program
    {
        static void Main(string[] args)
        {
            SMSParser parser = new SMSParser();

            
            if (args.Length == 0)
            {
                Console.WriteLine("Ending because of no argument");
                return;
            }

            Console.WriteLine("Args length: {0}", args[0]);

            if (args.Length == 1)
            {
                Console.WriteLine(parser.Parse("HelloWorld!"));
            }
            else if (args.Length == 2)
            {
                if (args[0] == "-f")
                {

                }
            }

            
            Console.WriteLine("App End");
        }
    }
}
