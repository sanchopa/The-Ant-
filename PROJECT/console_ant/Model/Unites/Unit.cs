using console_ant.Model.Attributes;
using console_ant.Model.Unites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_ant.Model
{
    class Unit: ISufferDamage, IAttacker, IDiable
    {
        Dictionary<string, UnitAttribute> attributes;
        


        public void SufferDamage(int damage)
        {
            this.attributes["health"].currentValue -= damage;
            if (this.attributes["health"].currentValue <= 0)
            {
                this.Die();
            }
        }

        public void Attack(ISufferDamage threate)
        {
            threate.SufferDamage(this.attributes["Attack"].currentValue);
        }

        public void Die()
        {
            
        }
    }
}
