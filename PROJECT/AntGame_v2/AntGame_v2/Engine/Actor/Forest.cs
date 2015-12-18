using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AntGame_v2.Engine.Actor
{
    public class Forest: IActor
    {
        private Environment _enviroment;

        public Forest(Environment enviroment)
        {
            _enviroment = enviroment;
        }
        
        public void Init()
        {
            children = new List<IActor>();
        }

        public void Update()
        {
            foreach (var actor in children)
            {
                actor.Update();
            }
        }

        public void Render()
        {
            foreach (var actor in children)
            {
                actor.Render();
            }
        }

        public void Destroy()
        {
            
        }
    }
}
