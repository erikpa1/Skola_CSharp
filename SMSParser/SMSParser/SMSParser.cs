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
                Console.WriteLine("Not parsing because of empty");
                return "";
            }

            string concatedString = "";
            //Dada.TralalaTraala,Dada!ahoj
            bool nextCharIsBig = true;
            bool misspellSpace = false;

            for (int i = 0; i < stringToParse.Length; i++)
            {
                char s = stringToParse[i];

                if (Char.IsUpper(s))
                {
                    if (nextCharIsBig == false)
                    {
                        if (misspellSpace == false)
                        {
                            concatedString += ' ';
                        }                        
                    }
                    else
                    {
                        misspellSpace = false;
                    }

                    if (nextCharIsBig == true)
                    {
                        concatedString += s;
                        nextCharIsBig = false;
                    }
                    else
                    {
                        concatedString += Char.ToLower(s);
                    }
                }
                else if (s == ',')
                {
                    concatedString += s;
                    concatedString += ' ';
                    misspellSpace = true;
                }
                else if (s == '.' || s == '!')
                {
                    concatedString += s;
                    concatedString += ' ';
                    nextCharIsBig = true;
                }
                else
                {
                    concatedString += s;
                }

            }

            return concatedString;

        }




    }
}
