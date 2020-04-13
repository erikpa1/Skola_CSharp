using System;
using System.Collections.Generic;
using System.Text;

using Konzolovka.LanguageManager;


namespace Konzolovka.CLI
{
    class CLI
    {
        CLIGame _game = null;

        public CLI()
        {

        }



        public void Start()
        {            
            Console.WriteLine(LanguageManager.LanguageManager.GetInstance()["CLI.Welcome"]);
            Console.WriteLine("1 - new game");
            Console.WriteLine("2 - load game");
        }

        private void StartNewGame()
        {
            _game = new CLIGame();
        }

        private void ShowSaves()
        {

        }

        private void LoadGame(String gameName)
        {

        }
        

    }
}
