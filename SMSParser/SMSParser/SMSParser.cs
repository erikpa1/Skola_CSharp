using System;
using System.Collections.Generic;
using System.Text;


namespace SMSParser
{
    class SMSParser
    {
        public SMSParser()
        {

        }

        public String Parse(string stringToParse)
        {
            if (stringToParse == null)
            {
                Console.WriteLine("Not parsing because of null");
                return "";
            }

            if (stringToParse == String.Empty)
            {
                Console.WriteLine("Nop parsing because of empty");
                return "";
            }

            string concatedString = "";

            foreach (char s in stringToParse)
            {
                if (concatedString.Length == 0)
                {
                    concatedString += s;
                }
                else
                {
                    if (Char.IsUpper(s))
                    {
                        concatedString += " ";
                        concatedString += s;
                    }
                    else if (s == ',')
                    {
                        concatedString += " ";
                        concatedString += s;
                    }
                    else
                    {
                        concatedString += s;
                    }
                }           
                               
            }

            return concatedString;
            
        }




    }
}
