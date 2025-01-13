namespace Exo_Banque.Models;

public sealed class Epargne : Compte
{
    public Epargne(string numero, Personne titulaire) : base(numero, titulaire)
    {
    }

    public Epargne(string numero, Personne titulaire, double solde) : base(numero, titulaire, solde)
    {
    }

    public DateTime? DateDernierRetrait { get; private set; }

    public override void Retrait(double montant)
    {

        if (Solde < montant) throw new InvalidOperationException("Le montant est trop élévé par rapport au solde.");
        base.Retrait(montant);
        DateDernierRetrait = DateTime.Now;
    }

    protected override double CalculInteret()
    {
        return Solde * 0.045;
    }
}
