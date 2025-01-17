namespace Carwash01.Models;

public delegate void Traitement(Voiture v);

public class Carwash
{
    public Traitement Traitement = null;

    public Carwash()
    {
        Traitement += Preparer;
        Traitement += Laver;
        Traitement += Secher;
        Traitement += Finaliser;
    }

    private void Preparer(Voiture v)
    {
        Console.WriteLine($"Je prépare la voiture : {v.Plaque}");
    }

    private void Laver(Voiture v)
    {
        Console.WriteLine($"Je lave la voiture : {v.Plaque}");
    }

    private void Secher(Voiture v)
    {
        Console.WriteLine($"Je sèche la voiture : {v.Plaque}");
    }

    private void Finaliser(Voiture v)
    {
        Console.WriteLine($"Je finalise la voiture : {v.Plaque}");
    }

    public void Traiter(Voiture v)
    {
        Traitement?.Invoke(v);
    }


}
