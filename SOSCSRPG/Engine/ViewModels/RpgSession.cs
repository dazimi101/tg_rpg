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
        // Properties
        public Player UserPlayer { get; set; }
        public Setting CurrentSetting { get; set; }

        // Constants
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

            CurrentSetting = new Setting();
            CurrentSetting.LocationName = "Apartment";
            CurrentSetting.LocationDescription = "This is your (very) humble abode. Coffee is the only form of sustenance here that won't make you yack.";
            CurrentSetting.LocationImage = "/Engine;component/Images/Settings/joseph-albanese-xx0oSB1YxRE-unsplash.jpg";
            CurrentSetting.XPosition = 0;
            CurrentSetting.YPosition = 0;
        }

    }
}
