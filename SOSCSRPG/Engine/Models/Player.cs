using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Engine.Models
{
    // Data binding does not know when the value of a property is changed, so raise a property changed event
    public class Player : INotifyPropertyChanged
    {
        private static string _playerName;
        private static string _rcType;
        private static int _hitPoints;
        private static int _rcPoints;
        private static int _class;
        private static int _gems;

        public string PlayerName 
        {
            get 
            { 
                return _playerName; 
            }  
            set
            {
                _playerName = value;
                onPropertyChanged("PlayerName");
            } 
        }
        // The type of RC cells in a ghoul's body determines what type of kagune they have
        public string RCType 
        { 
            get
            {
                return _rcType;
            } 
            set
            {
                _rcType = value;
                onPropertyChanged("RCType");
            }
        }
        public int HitPoints
        {
            get
            {
                return _hitPoints;
            }
            set
            {
                _hitPoints = value;
                onPropertyChanged("HitPoints");
            }
        }
        // Amount of RC is equivalent to XP points
        public int RCPoints
        {
            get
            {
                return _rcPoints;
            }
            set
            {
                _rcPoints = value;
                onPropertyChanged("RCPoints");
            }
        }
        // Ghoul class is equivalent to level
        public int Class
        {
            get
            {
                return _class;
            }
            set
            {
                _class = value;
                onPropertyChanged("Class");
            }
        }
        public int Gems
        {
            get
            {
                return _gems;
            }
            set
            {
                _gems = value;
                onPropertyChanged("Gems");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void onPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
