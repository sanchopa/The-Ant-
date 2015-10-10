using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheAntGame.Model
{
    public interface IAttacker 
    {
        void Attack(ISufferDamage threat);
    }
}
