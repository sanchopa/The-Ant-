using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TheAntGame.Model;

namespace TheAntGame.Model.Group
{
    public interface IDamageDivider
    {
        void DivideDamage(List<ISufferDamage> unites, double damage);

        void DivideDamage(List<Unit> list, double damage);
    }
}