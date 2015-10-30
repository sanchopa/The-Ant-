using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntGame_v2.Model
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
