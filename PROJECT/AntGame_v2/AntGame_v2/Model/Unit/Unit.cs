using TheAntGame.Model.Attribute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheAntGame.Tools;

namespace AntGame_v2.Model
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
            threat.SufferDamage(this.attributes["Atack"].maxValue);
        }

        public void SufferDamage(double damage)
        {
            if ((this.attributes["Health"].currentValue - damage) > 0 )
            {
                this.attributes["Health"].currentValue -= damage;                
            }
            else
            {
                this.attributes["Health"].currentValue = 0;
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
