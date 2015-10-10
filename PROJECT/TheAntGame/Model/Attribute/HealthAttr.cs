using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheAntGame.Model.Attribute
{
    class HealthAttr : UnitAttribute
    {
        public HealthAttr(double maxValue)
        {
            this.name = "Health";
            this.maxValue = maxValue;
        }
    }
}
