using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    public class Item
    {
        public int ID { get; set; }
        public int GemPrice { get; set; }
        public string Name { get; set; }

        public Item(int id, int gemPrice, string name)
        {
            ID= id;
            GemPrice= gemPrice;
            Name= name;
        }

        public Item Clone() => new Item(ID, GemPrice, Name);
    }
}
