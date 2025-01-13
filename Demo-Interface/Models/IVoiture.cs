using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Interface.Models
{
    internal interface IVoiture : IVehicule
    {
        int Distance { get; }
        void Avancer(int vitesse);
        void Tourner(string direction);
    }
}
