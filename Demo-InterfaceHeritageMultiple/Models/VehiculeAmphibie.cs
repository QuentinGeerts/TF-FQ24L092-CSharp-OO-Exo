using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_InterfaceHeritageMultiple.Models
{
    internal class VehiculeAmphibie : Voiture, IBateau
    {
        public void Naviguer()
        {
            Console.WriteLine("Je flotte! L'hélice tourne et m'emporte sur les flots!");
        }

        public override void Tourner()
        {
            base.Tourner();
            Console.WriteLine("Mais aussi, le gouvernaille pivote dans la bonne direction!");
        }
    }
}
