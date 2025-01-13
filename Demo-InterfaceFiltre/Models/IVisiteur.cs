using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_InterfaceFiltre.Models
{
    internal interface IVisiteur
    {
        string Nom { get; }
        void Sejourner(Personne p);
    }
}
