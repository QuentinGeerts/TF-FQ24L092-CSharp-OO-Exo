using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_Banque.Models
{
    public class Personne
    {
        public string Nom { get; set; } = string.Empty;

        public string Prenom { get; set; } = string.Empty;

        public DateTime DateNaiss { get; set; }
    }
}
