using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace console_project.Model.Group
{
    interface IDamageDivider
    {
        public void DivideDamage(List<ISufferDamage> unites, double damage);
    }
}
