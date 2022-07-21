using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.CharacterModels
{
    internal class Player
    {
        string PlayerName { get; set; }
        string PlayerClass { get; set; }
        int HitPoints { get; set; }
        int ExpPoints { get; set; }
        int Level { get; set; }
        int Gems { get; set; }
    }
}
