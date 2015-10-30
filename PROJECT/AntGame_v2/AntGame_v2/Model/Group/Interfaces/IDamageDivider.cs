using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace AntGame_v2.Model
{
    public interface IDamageDivider
    {
        void DivideDamage(List<ISufferDamage> unites, double damage);

        void DivideDamage(List<Unit> list, double damage);
    }
}
