using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Interface.Models
{
    internal interface IVehicule
    {
        string? NomConducteur { get; set; }
        string Couleur { get; }
        string Matricule { get; }

    }
}
