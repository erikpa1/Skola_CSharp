using System;
using System.Collections.Generic;
using System.Text;

namespace Konzolovka.Character
{
    class Slot<T>
    {
        private T _item = default(T);

        Delegate _onItemAdded = null;
        Delegate _onItemRemoved = null;

        public Slot()
        {
                     
        }

        public Slot(T item)
        {
            SetItem(item);
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

            if (_onItemAdded != null)
            {

            }
        }

        void RemoveItem(T item)
        {
            T tmpItem = _item;
            _item = default(T);

            if (_onItemRemoved != null)
            {

            }

        }


        




    }
}