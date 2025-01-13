using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Constructeur01.Models
{
    public class EtreVivant
    {
        public int PointDeVie { get; private set; }

        public EtreVivant(int pointDeVie)
        {
            PointDeVie = pointDeVie;
        }

        public void Vieillir()
        {
            PointDeVie--;
        }

        public void SeNourrir()
        {
            PointDeVie++;
        }
    }
}
