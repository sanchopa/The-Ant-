using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheAntGame.Model.Resource;

namespace TheAntGame.Model.Unit.Interfaces
{
    public interface ICarryResource
    {
        public void pickUpResource(AntResource resource);

        public void pickUpResource(AntResource resource, double count);

        public void dropResource(AntResource resource, double count);

        public void dropAll();
    }
}
