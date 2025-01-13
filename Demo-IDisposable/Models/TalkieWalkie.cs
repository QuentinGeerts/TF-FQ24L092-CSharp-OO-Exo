using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_IDisposable.Models
{
    public class TalkieWalkie : IDisposable
    {
        public string NomUtilisateur { get; set; }

        public void Dispose()
        {
            Console.WriteLine($"C'était {NomUtilisateur}, terminé!");
        }

        public void Parler(string message)
        {
            Console.WriteLine($"{NomUtilisateur} : {message}");
            Console.WriteLine("À vous!");
        }
    }
}
