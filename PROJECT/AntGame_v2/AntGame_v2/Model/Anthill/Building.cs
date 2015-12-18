using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AntGame_v2.Model
{
    public class Building: IBuilder
    {
        private int buildingLevel;

        public Building(int lvl)
        {
            this.buildingLevel = lvl;
        }
        
        public LevelUp()
        {
            this.buildingLevel++;
        }
    }
}
