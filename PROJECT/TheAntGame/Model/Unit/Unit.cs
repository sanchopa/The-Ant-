using TheAntGame.Model.Attribute;
using TheAntGame.Model;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheAntGame.Tools;

namespace TheAntGame.Model
{
    public class Unit: IAttacker, ISufferDamage, IMortal
    {
        Dictionary<string, UnitAttribute> attributes { get; set; }

        private string id;

        public Unit(IUnitIdProvider idProvider)
        {
            this.id = idProvider.GetNextUnitId();
        }

        public void Attack(ISufferDamage threat)
        {
            threat.SufferDamage(this.attributes["Atack"].MaxValue);
        }

        public void SufferDamage(double damage)
        {
            if ((this.attributes["Health"].CurrentValue - damage) > 0 )
            {
                this.attributes["Health"].CurrentValue -= damage;                
            }
            else
            {
                this.attributes["Health"].CurrentValue = 0;
                this.Die();
            }
        }


        public void Die()
        {
            
            // todo выбросить событие

        }

        public UnitAttribute GetAttribute(string name)
        {
           return this.attributes[name];
        }
    }
}
