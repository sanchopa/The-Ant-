using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheAntGame.Tools
{
    public class UnitIdProvider: IUnitIdProvider
    {
        private UInt64 counter;
        public UnitIdProvider()
        {
            counter = 0;
        }
        public UnitIdProvider(UInt64 counterStart)
        {
            counter = counterStart;
        }
        public string GetNextUnitId()
        {
            counter++;
            return "Uid" + counter.ToString();
            // такая большая жопа зашла в аудиторию

        }
    }
}
