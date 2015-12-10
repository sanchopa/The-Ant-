using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntGame_v2.Engine
{
    public interface IEngineActor
    {
        void Init();
        void Update();
        void Render();
        void Destroy();
    }
}
