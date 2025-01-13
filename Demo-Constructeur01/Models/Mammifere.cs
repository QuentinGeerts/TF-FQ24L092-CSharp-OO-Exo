using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Constructeur01.Models
{
    public class Mammifere : EtreVivant
    {
        public string Nom { get; private set; }
        public Mammifere(string nom, int pointDeVie) : base (pointDeVie)
        {
            Nom = nom;
        }
    }
}
