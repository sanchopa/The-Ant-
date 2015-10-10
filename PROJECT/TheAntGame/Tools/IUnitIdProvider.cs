using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheAntGame.Tools
{
    public interface IUnitIdProvider
    {
        string GetNextUnitId();
    }
}
