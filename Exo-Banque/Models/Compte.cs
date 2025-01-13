using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_Banque.Models
{
    public abstract class Compte : IBanker
    {
        public string Numero { get; set; }
        public double Solde { get; private set; }
        public Personne Titulaire { get; set; }

        public virtual void Retrait(double montant)
        {
            if (montant <= 0) throw new ArgumentException(nameof(montant), "Le montant doit être supérieur à 0.");
            Solde -= montant;
        }
        public void Depot(double montant)
        {
            if (montant <= 0) throw new ArgumentException(nameof(montant), "Le montant doit être supérieur à 0.");
            Solde += montant;
        }

        public void AppliquerInteret()
        {
            Solde += CalculInteret();
        }
        protected abstract double CalculInteret();

        public static double operator +(Compte left, Compte right)
        {
            /*
            double s1 = 0;
            double s2 = 0;
            if (left.Solde > 0)
            {
                s1 = left.Solde;
            }
            if (right.Solde > 0)
            {
                s2 = right.Solde;
            }
            return s1 + s2;

            //OU
            //return ((left.Solde > 0) ? left.Solde : 0) + ((right.Solde > 0) ? right.Solde : 0);
            //OU
            //return double.Max(0, left.Solde) + double.Max(0, right.Solde);*/
            return left.Solde + right;
        }

        public static double operator +(double left, Compte right)
        {
            double s1 = 0;
            double s2 = 0;
            if (left > 0)
            {
                s1 = left;
            }
            if (right.Solde > 0)
            {
                s2 = right.Solde;
            }
            return s1 + s2;

            //OU
            //return ((left > 0) ? left : 0) + ((right.Solde > 0) ? right.Solde : 0);
            //OU
            //return double.Max(0, left) + double.Max(0, right.Solde);
        }


    }
}
