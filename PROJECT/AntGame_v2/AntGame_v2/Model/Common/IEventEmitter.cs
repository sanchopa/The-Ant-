using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntGame_v2.Model
{
    public abstract class IEventEmitter
    {
        private List<IEventListener> listeners;

        abstract public void EmitEvent();

        abstract public void AddListener();

        abstract public void RemoveListener();


    }
}
