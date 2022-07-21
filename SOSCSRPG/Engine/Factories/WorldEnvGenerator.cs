using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Models;

namespace Engine.Factories
{
    public class WorldEnvGenerator
    {
        public WorldEnv GenerateWorldEnvironment()
        {
            WorldEnv world = new WorldEnv();

            world.AddLocationToWorld(0, 0, "Apartment", 
                "This is your (very) humble abode. Here, Coffee is the only form of sustenance that won't make you yack.", 
                "/Engine;component/Images/Settings/joseph-albanese-xx0oSB1YxRE-unsplash.jpg");

            world.AddLocationToWorld(0, 1, "Yoyogi Park",
                "Yoyogi park is infested with various hostile creatures.",
                "/Engine;component/Images/Settings/freddie-marriage-E9IB3-gp7OE-unsplash.jpg");

            world.AddLocationToWorld(0, 2, "Meiji Shrine",
                "Meiji Shrine bestows wisdom to those who seek it.",
                "/Engine;component/Images/Settings/alex_rainer-MWvtv8hlOz0-unsplash.jpg");

            world.AddLocationToWorld(1, 1, "Shibuya Library",
                "Crawling with C.C.G investigators, this library is not safe for a weak ghoul.",
                "/Engine;component/Images/Settings/alfons-morales-YLSwjSy7stw-unsplash.jpg");

            world.AddLocationToWorld(1, 0, "Shibuya Station",
                "A ghoul can easily hide themselves in the hustle and bustle of this crowded station.",
                "/Engine;component/Images/Settings/rezal-scharfe-wMAXEmlMZM0-unsplash.jpg");

            world.AddLocationToWorld(1, -1, "Shibuya Underground",
                "Starved ghouls, slum lords, and high-level investigators make the Underground the most dangerous place in all of Tokyo, for ghouls " +
                "and humans alike. Here, it's every-ghoul-for-themselves.",
                "/Engine;component/Images/Settings/alex-knight-5-GNa303REg-unsplash.jpg");

            world.AddLocationToWorld(0, -1, "Black Market",
                "Your destination for everything illegal but necessary. Beware of hostile traders.",
                "/Engine;component/Images/Settings/kanvz-pat-xx4vWG4mGL0-unsplash.jpg");

            world.AddLocationToWorld(-1, 0, "University",
                "The University rewards its students with immense knowledge.",
                "/Engine;component/Images/Settings/note-thanun-k4EfTi2WXLc-unsplash.jpg");

            world.AddLocationToWorld(-2, 0, "Museum",
                "The museum is occupied by various high and low level police gaurds.",
                "/Engine;component/Images/Settings/good-eason-GieHT_jQuhk-unsplash.jpg");

            return world;
        }
    }
}
