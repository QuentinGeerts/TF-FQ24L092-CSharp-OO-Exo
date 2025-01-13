using Exo_Banque.Models;

namespace Exo_Banque
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            Courant c1 = new Courant();
            c1.LigneCredit = 200;
            c1.Titulaire = new Personne()
            {
                Nom = "Doe",
                Prenom = "Jhon",
                DateNaiss = new DateTime(1987, 9, 27)
            };
            c1.Numero = "BE01";

            Courant c2 = new Courant() { 
                Numero = "BE02",
                LigneCredit = 200,
                Titulaire = c1.Titulaire
            };

            Epargne e1 = new Epargne()
            {
                Numero = "BE03",
                Titulaire = c1.Titulaire
            };

            Banque bank = new Banque();

            bank.Ajouter(c1);
            bank.Ajouter(c2);
            bank.Ajouter(e1);

            IBanker compteTraite = bank["BE01"];
            compteTraite.Depot(1500);

            Console.WriteLine($"Le titulaire du compte BE01 est {compteTraite.Titulaire.Nom}.");
            Console.WriteLine($"Le Solde du compte BE01 est {compteTraite.Solde} €.");

            compteTraite.Retrait(1600);
            Console.WriteLine($"Le Solde du compte BE01 est {compteTraite.Solde} €.");

            compteTraite = bank["BE02"];
            compteTraite.Depot(1500);

            Console.WriteLine($"Le titulaire du compte BE02 est {compteTraite.Titulaire.Nom}.");
            Console.WriteLine($"Le Solde du compte BE02 est {compteTraite.Solde} €.");

            compteTraite.Retrait(700);
            Console.WriteLine($"Le Solde du compte BE02 est {compteTraite.Solde} €.");

            compteTraite = bank["BE03"];

            compteTraite.Depot(500);

            Console.WriteLine($"Le titulaire du compte BE03 est {compteTraite.Titulaire.Nom}.");
            Console.WriteLine($"Le Solde du compte BE03 est {compteTraite.Solde} €.");

            compteTraite.Retrait(200);
            Console.WriteLine($"Le Solde du compte BE03 est {compteTraite.Solde} €.");
            if(compteTraite is Epargne epargneTraite)
            {
                if(epargneTraite.DateDernierRetrait is not null)
                {
                    Console.WriteLine($"Le dernier retrait date de {epargneTraite.DateDernierRetrait?.ToShortDateString()} {epargneTraite.DateDernierRetrait?.ToShortTimeString()}.");
                }
            }



            Console.WriteLine($"Si je calcule les avoirs de Jhon Doe, il aura : {bank.AvoirDesComptes(c1.Titulaire)} €.");

            string[] numeros = ["BE01", "BE02", "BE03"];
            foreach (string numero in numeros)
            {
                Compte compteAvecInteret = bank[numero];
                compteAvecInteret.AppliquerInteret();
                Console.WriteLine($"Le Solde du compte {numero} après intérêt est {compteAvecInteret.Solde} €.");
            }

            Console.WriteLine("Quel est votre nom?");
            string lastname = Console.ReadLine();
            Console.WriteLine("Quel est votre prénom?");
            string firstname = Console.ReadLine();
            Console.WriteLine("Quelle est la date de naissance (formatée : yyyy-mm-dd) ?");
            DateTime birth_date = DateTime.Parse(Console.ReadLine());

            Personne client = new Personne() { Nom = lastname, Prenom = firstname, DateNaiss = birth_date };

            client = bank[client];

            ICustomer[] mesComptes = bank.ComptesClient(client);
            Console.WriteLine("Veuillez sélectionner un compte par son numéro : ");
            for(int i = 0; i < mesComptes.Length; i++)
            {
                ICustomer compte = mesComptes[i];
                Console.WriteLine($"- Compte {i+1} : {compte.Solde} €.");
            }
            int choix = int.Parse(Console.ReadLine());
            ICustomer compteATraiter = mesComptes[choix - 1];
            Console.WriteLine("Que voulez-vous faire ?");
            Console.WriteLine("1 - Dépot");
            Console.WriteLine("2 - Retrait");
            string input = Console.ReadLine();
            Console.WriteLine("Quel montant ?");
            double montant = double.Parse(Console.ReadLine());
            switch (input)
            {
                case "1":
                    compteATraiter.Depot(montant);
                    break;
                default:
                    compteATraiter.Retrait(montant);
                    break;
            }
            Console.WriteLine($"Votre nouveau solde est de {compteATraiter.Solde} €");

        }
    }
}
