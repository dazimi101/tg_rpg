using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    public class Weapon : Item
    {
        public int MaxDmg { get; set; }
        public int MinDmg { get; set; }
        
        public Weapon (int id, int gemPrice, string name, int minDmg, int maxDmg)
            : base (id, gemPrice, name)
        {
            MinDmg = minDmg;
            MaxDmg = maxDmg;
        }
        public new Weapon Clone() => new Weapon(ID, GemPrice, Name, MinDmg, MaxDmg);
    }
}
