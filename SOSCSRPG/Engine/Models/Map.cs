using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Models;

namespace Engine.Models
{
    public class Map
    {
        private List<Setting> _settings = new List<Setting>();

        internal void AddLocationToWorld (int x, int y, string name, string desc, string img)
        {
            Setting setting = new Setting();
            setting.XPosition = x;
            setting.YPosition = y;
            setting.LocationName = name;
            setting.LocationDescription = desc;
            setting.LocationImage = img;
            _settings.Add(setting); 
        }
        public Setting ReturnSetting (int x, int y)
        {
            foreach (Setting setting in _settings)
            {
                if (setting.XPosition == x && setting.YPosition == y)
                {
                    return setting;
                }
            }
            return null;
        }
    }
}
