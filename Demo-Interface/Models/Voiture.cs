using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Interface.Models
{
    internal class Voiture :  IVehicule, IVoiture
    {
        public string Couleur { get; private set; }
        public string Matricule { get; private set; }
        public int Distance { get; private set; }
        public string? NomConducteur { get; set; }

        public Voiture(string couleur, string matricule)
        {
            Couleur = couleur;
            Matricule = matricule;
            Distance = 0;
        }
        public void Klaxonner()
        {
            Console.WriteLine("Tut tut!");
        }
        public void Avancer(int vitesse)
        {
            Console.WriteLine($"Je roule à {vitesse} km/h!");
            Distance += vitesse;
        }

        public void Tourner(string direction)
        {
            Console.WriteLine($"Je tourne à {direction}.");
        }
    }
}
