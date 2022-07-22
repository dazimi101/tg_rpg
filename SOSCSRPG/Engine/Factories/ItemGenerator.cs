using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Models;

namespace Engine.Factories
{
    public class ItemGenerator
    {
        public List<Item> Items;
        public List<Item> GenerateItemList()
        {
            Items = new List<Item>();
            Weapon Fists = new Weapon(10, 0, "Fists", 1, 1);
            Weapon Stick = new Weapon(11, 1, "Stick", 0, 2);
            Weapon KitchenKnife = new Weapon(12, 2, "Kitchen Knife", 1, 3);

            Items.Add(Fists);
            Items.Add(Stick);
            Items.Add(KitchenKnife);

            return Items;
        }

        public Item GenerateNewItem(int itemID)
        {
            foreach (Item item in Items)
            {
                if (item.ID == itemID)
                {
                    return item.Clone();
                }
            }
            return null;
        }
    }
}
