using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_InterfaceHeritageMultiple.Models
{
    internal class Bateau : IBateau
    {
        public void Naviguer()
        {
            Console.WriteLine("Je flotte! L'hélice tourne et m'emporte sur les flots!");
        }

        public void Tourner()
        {
            Console.WriteLine("Lorsque je tourne la barre, le gouvernaille pivote dans la bonne direction!");
        }
    }
}
