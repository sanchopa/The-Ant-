using AntGame_v2.Engine.Actor;
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
        public Forest TheForest { get; set; }
        public List<Group> Groups { get; set; }
        
        /// <summary>
        /// Просто инициализируем массивы
        /// </summary>
        public AntEnviroment()
        {
            
        }
    }
}
