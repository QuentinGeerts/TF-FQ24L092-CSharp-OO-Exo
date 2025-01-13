using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Polymorphisme01.Models
{
    public class Joueur
    {
        public string Nom {  get; set; }

        private List<ObjetInventaire> _inventaire = new List<ObjetInventaire>();

        public ObjetInventaire[] Inventaire
        {
            get { return _inventaire.ToArray() ?? new ObjetInventaire[0];}
        }

        public void Ramasser(ObjetInventaire objet)
        {
            _inventaire.Add(objet);
        }

        public void Utiliser(ObjetInventaire objet)
        {
            if (!_inventaire.Contains(objet)) throw new InvalidOperationException();
            objet.Utiliser();
        }
    }
}
