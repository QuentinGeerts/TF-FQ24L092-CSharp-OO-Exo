using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Heritage01.Models
{
    public class Vehicule
    {
        public string Matricule { get; set; }
        public int NombrePlaces { get; set; }

        public int Position { get; protected set; } = 0;

        public void Avancer(int vitesse)
        {
            Position += vitesse;
            Console.WriteLine($"J'avance à {vitesse} km/h! Je suis à {Position}Km...");
        }

        public override string ToString()
        {
            return $"Véhicule immatriculé {Matricule} avec {NombrePlaces} places. Est à {Position} km de son point de départ";
        }

        protected string BaseToString()
        {
            return base.ToString();
        }
    }
}
