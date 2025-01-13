using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_InterfaceFiltre.Models
{
    internal class Propriete : IProprietaire, IVisiteur
    {
        public string Nom { get; set; }
        public int Prix { get; set; }
        public Personne? Proprietaire { get; set; }
        public bool EstHypotequee { get; set; } = false;

        public void ChangerHypoteque() { 
            EstHypotequee = !EstHypotequee;
        }

        public void Sejourner(Personne visiteur)
        {
            if (EstHypotequee)
            {
                Console.WriteLine($"{visiteur.Nom} ne peux pas dormir à {Nom}... C'est Hypothéquée.");
            }
            else
            {
                Console.WriteLine($"{visiteur.Nom} dort à {Nom}.");
            }
        }
    }
}
