using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_ant.Model.Attributes
{
    public class AttackAttr: UnitAttribute
    {
        public AttackAttr()
        {
            this.name = "Attack";
        }
        public AttackAttr(int value)
        {
            this.name = "Attack";
            this.currentValue = value;
        }
    }
}
