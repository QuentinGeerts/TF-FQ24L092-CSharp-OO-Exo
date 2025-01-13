using Demo_InterfaceFiltre.Models;

namespace Demo_InterfaceFiltre
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Personne> joueurs = new List<Personne>()
                {
                new Personne() { Nom = "Thierry" },
                new Personne() { Nom = "Michaël" }
                };

            List<Propriete> proprietes = new List<Propriete>()
            {
                new Propriete() { Nom = "TFTIC", Prix = 200},
                new Propriete() { Nom = "E6K", Prix = 220 }
            };


            for (int i = 0; i < 20; i++)
            {
                Random RNG = new Random();
                Personne j = joueurs[i % joueurs.Count];
                Propriete prop = proprietes[RNG.Next(2)];
                if(prop.Proprietaire is null)
                {
                    prop.Proprietaire = j;
                }
                else
                {
                    if(j == prop.Proprietaire)
                    {
                        ActionProprietaire(prop);
                    }
                    else
                    {
                        ActionVisiteur(j, prop);
                    }
                }
            }
        }

        static void ActionProprietaire(IProprietaire propriete)
        {
            Console.WriteLine($"Vous êtes chez vous! ({propriete.Nom})");
            Console.WriteLine($"Que voulez-vous faire?");
            Console.WriteLine($"Changer l'hypothèque? (La propriété {(propriete.EstHypotequee ? "est déjà" : "n'est pas")} hypotéquée)");
            string answer = Console.ReadLine();
            if (answer == "oui")
            {
                propriete.ChangerHypoteque();
                Console.WriteLine("Changement effectué.");
            }
        }

        static void ActionVisiteur(Personne visiteur, IVisiteur propriete)
        {
            Console.WriteLine($"Vous êtes arrivé à ({propriete.Nom}). Reposez-vous!");
            propriete.Sejourner(visiteur);
        }
    }
}
