using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_Banque.Models
{
    public class Banque
    {

        private Dictionary<String, Compte> Comptes = new Dictionary<string, Compte>(); 

        public Compte this[String numero]
        {
            get
            {
                return Comptes[numero];
            }
        }

        public Personne? this[string first_name, string last_name, DateTime birth_date]
        {
            get {
                foreach (KeyValuePair<string, Compte> kvp_compte in Comptes)
                {
                    Compte c = kvp_compte.Value;
                    if (first_name == c.Titulaire.Prenom 
                        && last_name == c.Titulaire.Nom 
                        && birth_date == c.Titulaire.DateNaiss)
                        return c.Titulaire;
                }
                return null;
            }
        }

        public Personne? this[Personne client]
        {
            get
            {
                foreach (KeyValuePair<string, Compte> kvp_compte in Comptes)
                {
                    Compte c = kvp_compte.Value;
                    if (client.Prenom == c.Titulaire.Prenom 
                        && client.Nom == c.Titulaire.Nom 
                        && client.DateNaiss == c.Titulaire.DateNaiss)
                        return c.Titulaire;
                }
                return null;
            }
        }

        public void Ajouter(Compte courant)
        {
            if (!String.IsNullOrWhiteSpace(courant.Numero))
            {
                Comptes.Add(courant.Numero, courant);
            }
            else
            {
                throw new Exception("Le numéro de compte doit être informé.");
            }
            
        }

        public void Supprimer(String numero)
        {
            Comptes.Remove(numero);
        }

        public double AvoirDesComptes(Personne titulaire)
        {
            double soldeAvoirs = 0;
            foreach (KeyValuePair<string,Compte> kvpNumeroCompte in Comptes)
            {
                if(kvpNumeroCompte.Value.Titulaire == titulaire)
                {
                    soldeAvoirs += kvpNumeroCompte.Value;
                }
            }
            return soldeAvoirs;
        }

        public ICustomer[] ComptesClient(Personne titulaire)
        {
            List<ICustomer> comptes = new List<ICustomer>();
            foreach (KeyValuePair<string, Compte> kvpNumeroCompte in Comptes)
            {
                if (kvpNumeroCompte.Value.Titulaire == titulaire)
                {
                    comptes.Add(kvpNumeroCompte.Value);
                }
            }
            return comptes.ToArray();
        }
    }
}
