using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_project.Model
{
    public interface IAttacker 
    {
        public void Attack(ISufferDamage threat);
    }
}
