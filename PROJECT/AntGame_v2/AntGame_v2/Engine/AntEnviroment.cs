using AntGame_v2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntGame_v2.Engine
{
    public class AntEnviroment
    {
        public IEnumerable<IActor> Actors { get; set; }
        public Forest forest;

        public AntEnviroment()
        {

        }

        

        private Forest LoadTestForest()
        {

            var testForest = new Forest();



            return testForest;

        }

    }
}
