using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_InterfaceHeritageMultiple.Models
{
    internal interface IBateau : IVehicule
    {
        void Naviguer();
        void Tourner();
    }
}
