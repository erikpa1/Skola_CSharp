using System;
using System.Collections.Generic;
using System.Text;

namespace Konzolovka.Character
{
    class Avatar
    {
        private Inventory _inventory;

        private Slot<Item> _item_Head;
        private Slot<Item> _item_Neck;
        private Slot<Item> _item_Chest;
        private Slot<Item> _item_Gloves;
        private Slot<Item> _item_Wrists;
        private Slot<Item> _item_Belt;
        private Slot<Item> _item_Legs;
        private Slot<Item> _item_Boots;
        private Slot<Item> _item_Ring_Left;
        private Slot<Item> _item_Ring_Right;
        private Slot<Item> _item_Weapon_Left;
        private Slot<Item> _item_Weapon_Right;

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
