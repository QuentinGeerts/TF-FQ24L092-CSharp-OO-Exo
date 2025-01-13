using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_Banque.Models
{
    public sealed class Courant : Compte
    {       

        private double _ligneCredit = 15;

        public double LigneCredit
        {
            get { return _ligneCredit; }
            set
            {
                _ligneCredit = double.Clamp(value, 0, double.MaxValue);
            }
        }        

        public override void Retrait(double montant)
        {
            if (-LigneCredit > Solde - montant) throw new Exception("Le solde depasse le montant autorisé par le crédit.");
            base.Retrait(montant);
        }

        protected override double CalculInteret()
        {
            if (Solde < 0) return Solde * 0.0975;
            else return Solde * 0.03;

            //return (Solde < 0) ? Solde * 0.0975 : Solde * 0.03;
        }
    }
}
