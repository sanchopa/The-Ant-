using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntGame_v2.Engine
{
    public class Engine
    {
        private AntEnviroment _enviroment;
        private  bool isPaused;
        

        public Engine(AntEnviroment enviroment)
        {
            _enviroment = enviroment;
        }

        public void Start()
        {
            Initialize();
            Continue();
        }

        private void Initialize()
        {
            foreach (var actor in _enviroment.Actors)
            {
                actor.Init();
            } 
        }

        public void Continue()
        {
            isPaused = false;
            while (!isPaused)
            {
                foreach (var actor in _enviroment.Actors)
                {
                    actor.Update();
                } 
                foreach (var actor in _enviroment.Actors)
                {
                    actor.Render();
                }
            }
        }

        public void Pause()
        {
            isPaused = true;
        }

        public void Stop()
        {
            Pause();
            foreach (var actors in _enviroment.Actors)
            {
                actors.Destroy();
            }
        }
    }
}
