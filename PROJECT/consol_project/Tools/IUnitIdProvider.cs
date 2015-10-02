using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_project.Tools
{
    public interface IUnitIdProvider
    {
        public string GetNextUnitId();
    }
}
