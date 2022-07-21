using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Models;

namespace Engine.ViewModels
{
    public class RpgSession
    {
        // Create UserPlayer Player property and initialize constant variable for Player fields
        public Player UserPlayer { get; set; }
        public const int InitialWealth = 100;
        public const int InitialRC = 1000;
        public const int InitialHealth = 0;
        public const int InitialClass = 1;

        public RpgSession()
        {
            UserPlayer = new Player();
            UserPlayer.PlayerName = "Daisuke";
            // First word is (in my head) the English equivalent to one of the four types of RC classification
            UserPlayer.RCType = "Rogue (Ukaku)";
            UserPlayer.HitPoints = InitialHealth;
            UserPlayer.RCPoints = InitialRC;
            UserPlayer.Gems = InitialWealth;
            UserPlayer.Class = InitialClass;
        }

    }
}
