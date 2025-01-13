using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_Banque.Models
{
    public interface ICustomer
    {
        double Solde { get; }

        void Depot(double montant);
        void Retrait(double montant);
    }
}
