using System;
using System.Collections.Generic;
using System.Text;

namespace Konzolovka.Character
{
    class Slot<T>
    {
        private T _item;

        public Slot()
        {
            _item = default(T);            
        }
               
        bool HasObject()
        {
            return _item != null;
        }

        void SetItem(T item)
        {
            if (HasObject())
            {
                throw new Exception("Item already in slot");
            }
            else
            {
                _item = item;
            }
        }


        




    }
}