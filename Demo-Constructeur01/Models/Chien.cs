using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Constructeur01.Models
{
    public class Chien : Mammifere
    {
        public string Taille { get; private set; }
        public Chien(string nom, string taille) : base(nom, 15)
        {
            Taille = taille;
        }
        public override string ToString()
        {
            return $"En tant qu'être vivant : {PointDeVie} PV\nEn tant que mammifère, le nom : {Nom}\nEn tant que chien, ce chien est de taille : {Taille}";
        }
    }
}
