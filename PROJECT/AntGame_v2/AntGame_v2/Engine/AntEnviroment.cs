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
        public Forest forest;
        

        internal void Generate()
        {
            forest = LoadTestForest();            
        }

        private Forest LoadTestForest()
        {

            var testForest = new Forest();



            return testForest;

        }

    }
}
