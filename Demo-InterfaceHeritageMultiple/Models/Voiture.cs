using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_InterfaceHeritageMultiple.Models
{
    internal class Voiture : IVoiture
    {
        public void Rouler()
        {
            Console.WriteLine("Les roues tournent, j'avance!");
        }

        public virtual void Tourner()
        {
            Console.WriteLine("Quand je tourne le volant, les roues pivotent dans la même direction.");
        }
    }
}
