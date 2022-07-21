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

            world.AddLocationToWorld(0, 0, "Apartment", "This is your (very) humble abode. Here, Coffee is the only form of sustenance that won't make you yack.", "/Engine;component/Images/Settings/joseph-albanese-xx0oSB1YxRE-unsplash.jpg");

            return world;
        }
    }
}
