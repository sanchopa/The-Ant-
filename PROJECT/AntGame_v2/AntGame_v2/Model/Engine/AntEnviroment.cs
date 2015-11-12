using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntGame_v2.Model.Engine
{
    public class AntEnviroment
    {
        public IEnumerable<IEngineActor> Actors { get; set; }

        internal void Generate()
        {
            throw new NotImplementedException();
        }

    }
}
