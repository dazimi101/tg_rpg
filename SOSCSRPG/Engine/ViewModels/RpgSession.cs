using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Models;
using Engine.Factories;
using System.ComponentModel;

namespace Engine.ViewModels
{
    public class RpgSession : UpdateHandler
    {
        private Setting _currentSetting;
        // Properties
        public Player UserPlayer { get; set; }
        public WorldEnv CurrentWorld { get; set; }
        public Setting CurrentSetting
        {
            get
            {
                return _currentSetting;
            }
            set
            {
                _currentSetting = value;
                onPropertyChanged(nameof(CurrentSetting));
                onPropertyChanged(nameof(HasUp));
                onPropertyChanged(nameof(HasLeft));
                onPropertyChanged(nameof(HasDown));
                onPropertyChanged(nameof(HasRight));
            }
        }

        // Location boolean checkers (to hide XAML buttons)

        public bool HasUp
        {
            get
            {
                return CurrentWorld.ReturnSetting(CurrentSetting.XPosition, CurrentSetting.YPosition + 1) != null;
            }
        }

        public bool HasLeft
        {
            get
            {
                return CurrentWorld.ReturnSetting(CurrentSetting.XPosition - 1, CurrentSetting.YPosition) != null;
            }
        }

        public bool HasDown
        {
            get
            {
                return CurrentWorld.ReturnSetting(CurrentSetting.XPosition, CurrentSetting.YPosition - 1) != null;
            }
        }

        public bool HasRight
        {
            get
            {
                return CurrentWorld.ReturnSetting(CurrentSetting.XPosition + 1, CurrentSetting.YPosition) != null;
            }
        }

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

        public void MoveUp()
        {
            CurrentSetting = CurrentWorld.ReturnSetting(CurrentSetting.XPosition, CurrentSetting.YPosition+1);
        }
        public void MoveLeft()
        {
            CurrentSetting = CurrentWorld.ReturnSetting(CurrentSetting.XPosition-1, CurrentSetting.YPosition);
        }

        public void MoveDown()
        {
            CurrentSetting = CurrentWorld.ReturnSetting(CurrentSetting.XPosition, CurrentSetting.YPosition-1);
        }
        public void MoveRight()
        {
            CurrentSetting = CurrentWorld.ReturnSetting(CurrentSetting.XPosition+1, CurrentSetting.YPosition);
        }
    }
}
    