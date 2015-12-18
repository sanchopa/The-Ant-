using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntGame_v2.Engine
{
    public abstract class IActor
    {
        public List<IActor> children;
        public readonly int Id;

        public void Init();
        public void Update();
        public void Render();
        public void Destroy();
    }
}
