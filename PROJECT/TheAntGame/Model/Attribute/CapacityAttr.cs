using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheAntGame.Model.Attribute
{
    class CapacityAttr: UnitAttribute
    {
        public CapacityAttr(double maxValue)
        {
            this.Name = "Capacity";
            this.MaxValue = maxValue;
            this.CurrentValue = 0;
        }
    }
}
