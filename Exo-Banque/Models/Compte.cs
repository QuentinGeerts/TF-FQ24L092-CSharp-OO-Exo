﻿namespace Exo_Banque.Models;

//public delegate void PassageEnNegatifDelegate(Compte c);

public abstract class Compte : IBanker
{
    protected Compte(string numero, Personne titulaire) : this(numero, titulaire, 0)
    {

    }

    protected Compte(string numero, Personne titulaire, double solde)
    {
        Numero = numero;
        Titulaire = titulaire;
        Solde = solde;
    }

    //public event PassageEnNegatifDelegate PassageEnNegatifEvent;
    public event Action<Compte> PassageEnNegatifEvent;

    public string Numero { get; private set; }
    public double Solde { get; private set; }
    public Personne Titulaire { get; private set; }

    public virtual void Retrait(double montant)
    {
        if (montant <= 0) throw new ArgumentOutOfRangeException(nameof(montant), "Le montant doit être supérieur à 0.");
        Solde -= montant;
    }
    public void Depot(double montant)
    {
        if (montant <= 0) throw new ArgumentOutOfRangeException(nameof(montant), "Le montant doit être supérieur à 0.");
        Solde += montant;
    }

    public void AppliquerInteret()
    {
        Solde += CalculInteret();
    }
    protected abstract double CalculInteret();

    public static double operator +(Compte left, Compte right)
    {
        /*
        double s1 = 0;
        double s2 = 0;
        if (left.Solde > 0)
        {
            s1 = left.Solde;
        }
        if (right.Solde > 0)
        {
            s2 = right.Solde;
        }
        return s1 + s2;

        //OU
        //return ((left.Solde > 0) ? left.Solde : 0) + ((right.Solde > 0) ? right.Solde : 0);
        //OU
        //return double.Max(0, left.Solde) + double.Max(0, right.Solde);*/
        return left.Solde + right;
    }

    public static double operator +(double left, Compte right)
    {
        double s1 = 0;
        double s2 = 0;
        if (left > 0)
        {
            s1 = left;
        }
        if (right.Solde > 0)
        {
            s2 = right.Solde;
        }
        return s1 + s2;

        //OU
        //return ((left > 0) ? left : 0) + ((right.Solde > 0) ? right.Solde : 0);
        //OU
        //return double.Max(0, left) + double.Max(0, right.Solde);
    }

    protected void PassageEnNegatif()
    {
        PassageEnNegatifEvent?.Invoke(this);
    }
}
