﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheAntGame.Model.Attribute
{
    class SpeedAttr: UnitAttribute
    {
        public SpeedAttr(double unitSpeed)
        {
            this.Name = "Speed";
            this.MaxValue = MaxValue;
            this.CurrentValue = MaxValue;
        }

    }
}
