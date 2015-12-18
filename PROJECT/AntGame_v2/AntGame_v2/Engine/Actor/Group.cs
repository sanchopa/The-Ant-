using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntGame_v2.Engine.Actor
{
    class Group: IActor
    {
        private AntEnviroment _envitoment;
        public Group (AntEnviroment enviroment)
        {
            _envitoment = enviroment;
        }
        public void Init()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {


            _envitoment.
        }

        public void Render()
        {
            throw new NotImplementedException();
        }

        public void Destroy()
        {
            throw new NotImplementedException();
        }
    }
}
