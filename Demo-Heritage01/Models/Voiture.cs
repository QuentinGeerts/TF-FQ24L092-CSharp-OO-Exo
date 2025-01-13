using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Heritage01.Models
{
    public sealed class Voiture : Vehicule
    {
        public int NombreRoues { get; set; }

        public new void Avancer(int vitesse)
        {
            Position += vitesse;
            Console.WriteLine($"Je roule à {vitesse} km/h! Je suis à {Position}Km...");
        }

        public override string ToString()
        {
            return $"{BaseToString()}\nJe suis en voiture.\n{base.ToString()}\nElle a {NombreRoues} roue(s).";
        }
    }
}
