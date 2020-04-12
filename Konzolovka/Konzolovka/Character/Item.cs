using System;
using System.Collections.Generic;
using System.Text;

namespace Konzolovka.Character
{
    class Item
    {
        private string _type;
        private string _subtype;

        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }

        public string Subtype
        {
            get { return _subtype;  }
            set { _subtype = value; }
        }



    }
}
