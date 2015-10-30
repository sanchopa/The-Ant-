using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AntGame_v2.Model
{
    public interface ICarryResource
    {
        void pickUpResource(AntResource resource);

        void pickUpResource(AntResource resource, double count);

        void dropResource(AntResource resource, double count);

        void dropAll();
    }
}
