using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Models;
using Engine.Factories;

namespace Engine.ViewModels
{
    public class RpgSession
    {
        // Properties
        public Player UserPlayer { get; set; }
        public Setting CurrentSetting { get; set; }
        public WorldEnv CurrentWorld { get; set; }

        // Constants
        public const int InitialWealth = 100;
        public const int InitialRC = 1000;
        public const int InitialHealth = 0;
        public const int InitialClass = 1;

        public RpgSession()
        {
            UserPlayer = new Player
            {
                PlayerName = "Daisuke",
                // First word is (in my head) the English equivalent to one of the four types of RC classification
                RCType = "Rogue (Ukaku)",
                HitPoints = InitialHealth,
                RCPoints = InitialRC,
                Gems = InitialWealth,
                Class = InitialClass
            };

            WorldEnvGenerator generator = new WorldEnvGenerator();

            CurrentWorld = generator.GenerateWorldEnvironment();

            CurrentSetting = CurrentWorld.ReturnSetting(0, 0);
        }
    }
}
