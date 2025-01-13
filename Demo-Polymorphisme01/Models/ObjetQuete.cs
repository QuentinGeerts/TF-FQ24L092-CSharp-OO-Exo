using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Polymorphisme01.Models
{
    public class ObjetQuete : ObjetInventaire
    {
        public override void Utiliser()
        {
            Console.WriteLine($"Le joueur utilise {Nom}!");
        }
    }
}
