using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntGame_v2.Model
{
    public abstract class IEventListener
    {
        void HandleEvent(AntEvent e) { }
    }
}
