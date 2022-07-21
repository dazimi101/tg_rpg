using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    public class Player
    {
        public string PlayerName { get; set; }
        // The type of RC cells in a ghoul's body determines what type of kagune they have
        public string RCType { get; set; }
        public int HitPoints { get; set; }
        // Amount of RC is equivalent to XP points
        public int RCPoints { get; set; }
        // Ghoul class is equivalent to level
        public int Class { get; set; }
        public int Gems { get; set; }
    }
}
