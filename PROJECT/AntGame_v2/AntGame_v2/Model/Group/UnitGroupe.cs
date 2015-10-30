using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AntGame_v2.Model
{
    class UnitGroup: ISufferDamage, IAttacker
    {

        private IDamageDivider _divider;
        private int _currentSpeed;
        
        public List<Unit> unites;

        public UnitGroup(Unit[] unites, IDamageDivider damageDivider)
        {
            this.unites = new List<Unit>();
            this.unites.AddRange(unites);
            this._divider = damageDivider;

            
        }



        public void Attack(ISufferDamage threat)
        {
            
            threat.SufferDamage(CalculateSummDamage());
        }

        private double CalculateSummDamage()
        {
            double summ = 0;
            foreach (var Unit in unites)
            {
                summ += Unit.GetAttribute("Attack").maxValue;
            }
            return summ;
        }

        public void SufferDamage(double damage)
        {
            this._divider.DivideDamage(this.unites, damage);
            if (this.unites.Count == 0)
            {
                // что то (уничтожить группу)
            }
        }
    }
}
