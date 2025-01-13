using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Polymorphisme01.Models
{
    public class ObjetSoin : ObjetInventaire
    {
        public int Bonus { get; set; }

        public override void Utiliser()
        {
            Console.WriteLine($"Le joueur se soigne avec {Nom} et regagne {Bonus}.");
        }
    }
}
