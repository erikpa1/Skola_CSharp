using System;

using Konzolovka.CLI;

namespace Konzolovka
{
    class Program
    {
        static void Main(string[] args)
        {
            LanguageManager.LanguageManager.GetInstance().SetLanguage("English");

            CLI.CLI console = new CLI.CLI();
            console.Start();
        }
    }
}
