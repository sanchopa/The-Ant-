using AntGame_v2.Model.Engine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntGame_v2
{
    class Program
    {
        static void Main(string[] args)
        {
            AntEnviroment enviroment = new AntEnviroment();

            enviroment.Generate();

            while (true)
            {
                foreach (var actor in enviroment.Actors)
                {
                    actor.Update();
                    actor.Render();
                }
            }
        }
    }
}
