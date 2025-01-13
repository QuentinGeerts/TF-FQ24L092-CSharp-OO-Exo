namespace Exo_Banque.Models;

public class Personne
{
    public Personne(string nom, string prenom, DateTime dateNaiss)
    {
        Nom = nom;
        Prenom = prenom;
        DateNaiss = dateNaiss;
    }

    public string Nom { get; private set; } = string.Empty;

    public string Prenom { get; private set; } = string.Empty;

    public DateTime DateNaiss { get; private set; }
}
