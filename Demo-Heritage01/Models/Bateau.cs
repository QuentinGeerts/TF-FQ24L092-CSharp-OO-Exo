using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Heritage01.Models
{
    public class Bateau : Vehicule
    {
        public bool EstMotorise { get; set; }
        public new void Avancer(int vitesse)
        {
            Position += vitesse;
            Console.WriteLine($"Je navigue à {vitesse} km/h! Je suis à {Position}Km...");
        }
    }
}
