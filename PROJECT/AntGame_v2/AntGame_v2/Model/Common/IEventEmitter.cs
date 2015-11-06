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

        public void EmitEvent();

        public void AddListener();

        public void RemoveListener();


    }
}
