using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheAntGame.Model.Attribute
{
    public class UnitAttribute
    {
        public string Name { get; set; }
        public double MaxValue { get; set; }
        public double CurrentValue { get; set; }

        public UnitAttribute()
        {

        }
    }
}
