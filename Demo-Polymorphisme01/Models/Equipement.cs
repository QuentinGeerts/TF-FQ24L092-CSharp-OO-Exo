using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Polymorphisme01.Models
{
    public class Equipement : ObjetInventaire
    {
        public int Bonus { get; set; }
        public bool EstEquipe { get; set; }

        public override void Utiliser()
        {
            if (EstEquipe)
            {
                Console.WriteLine($"Le joueur enlève l'équipement {Nom}");
            }
            else
            {
                Console.WriteLine($"Le joueur s'équipe de {Nom}.");
            }
            EstEquipe = !EstEquipe;
        }
    }
}
