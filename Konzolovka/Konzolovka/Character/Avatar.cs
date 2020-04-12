using System;
using System.Collections.Generic;
using System.Text;

namespace Konzolovka.Character
{
    class Avatar
    {
        private Inventory _inventory;

        private Item _item_Head;
        private Item _item_Neck;
        private Item _item_Chest;
        private Item _item_Gloves;
        private Item _item_Wrists;
        private Item _item_Belt;
        private Item _item_Legs;
        private Item _item_Boots;
        private Item _item_Ring_Left;
        private Item _item_Ring_Right;
        private Item _item_Weapon_Left;
        private Item _item_Weapon_Right;

        public Avatar()
        {
            _inventory = new Inventory();

            _item_Head = null;
            _item_Neck = null;
            _item_Chest = null;
            _item_Gloves = null;
            _item_Wrists = null;
            _item_Belt = null;
            _item_Legs = null;
            _item_Boots = null;
            _item_Ring_Left = null;
            _item_Ring_Right = null;
            _item_Weapon_Left = null;
            _item_Weapon_Right = null;

        }






    }
}
