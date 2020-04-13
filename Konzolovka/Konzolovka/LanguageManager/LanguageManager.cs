using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Konzolovka.LanguageManager
{
    class LanguageManager
    {
        private static LanguageManager _instance = null;
        public static LanguageManager GetInstance()
        {
            if (_instance == null)
            {
                _instance = new LanguageManager();
                return _instance;
            }

            return _instance;
        }

        private Dictionary<String, String> _langs = new Dictionary<string, string>();

        public void Construct()
        {
        }

        public void SetLanguage(String language)
        {
            File.ReadAllText("../../../../" + language + ".txt");

        }

        public string this[String key]
        {
            set
            {
                throw new Exception("You cant add to language manager from this");
            }

            get
            {
                if (_langs.ContainsKey(key))
                {
                    return _langs[key];
                }
                else
                {
                    return key;
                }
            }
        }

    }
}
