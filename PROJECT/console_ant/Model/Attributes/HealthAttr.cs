using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_ant.Model.Attributes
{
    class HealthAttr: UnitAttribute
    {
        public HealthAttr()
        {
            this.name = "Health";
        }
        public HealthAttr(int value)
        {
            this.name = "Health";
            this.currentValue = value;
        }
    }
}
