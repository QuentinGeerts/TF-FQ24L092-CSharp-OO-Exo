using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Heritage01.Models
{
    public class TestVehicule : Vehicule
    {
        /*public string Matricule { get; set; }
        public int NombrePlaces { get; set; }

        public int Position { get; private set; } = 0;

        public void Avancer(int vitesse)
        {
            Position += vitesse;
            Console.WriteLine($"J'avance à {vitesse} km/h! Je suis à {Position}Km...");
        }*/

        public new void Avancer(int vitesse)
        {
            Position += vitesse * 10;
            Console.WriteLine($"Je me téléporte à {Position}...");
        }
    }
}
