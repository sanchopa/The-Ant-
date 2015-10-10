using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheAntGame.Model.Attribute
{
    public class UnitAttribute
    {
        public string name { get; set; }
        public double maxValue { get; set; }
        public double currentValue { get; set; }

        public UnitAttribute()
        {

        }
    }
}
