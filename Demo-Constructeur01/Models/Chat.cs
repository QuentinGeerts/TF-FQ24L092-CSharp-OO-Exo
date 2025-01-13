using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Demo_Constructeur01.Models
{
    public class Chat : Mammifere
    {
        private const int PV_INIT = 10;
        public string CouleurColier { get; set; }
        public Chat(string nom) : this(nom, null)
        {
        }

        public Chat(string nom, string couleurColier) : base(nom, PV_INIT)
        {
            CouleurColier = couleurColier;
        }

        public override string ToString()
        {
            return $"En tant qu'être vivant : {PointDeVie} PV\nEn tant que mammifère, le nom : {Nom}\nEn tant que chat, la couleur de colier : {CouleurColier}";
        }
    }
}
