using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntGame_v2.Model
{
    class AttackAttr: UnitAttribute
    {
        public AttackAttr(double maxValue)
        {
            this.name = "Attack";
            this.maxValue = maxValue;
        }

    }
}
