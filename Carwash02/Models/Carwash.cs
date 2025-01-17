namespace Carwash02.Models;

public delegate void Traitement(Voiture v);

public class Carwash
{
    private Traitement Traitement = null;

    public Carwash()
    {
        // Méthodes anonymes
        Traitement += delegate (Voiture v)
        {
            Console.WriteLine($"Je prépare la voiture : {v.Plaque}");
        };
        Traitement += delegate (Voiture v)
        {
            Console.WriteLine($"Je lave la voiture : {v.Plaque}");
        };

        // Expression lambda
        Traitement += (Voiture v) => Console.WriteLine($"Je sèche la voiture : {v.Plaque}");
        Traitement += (Voiture v) => Console.WriteLine($"Je finalise la voiture : {v.Plaque}");
    }

    public void Traiter(Voiture v)
    {
        Traitement?.Invoke(v);
    }
}
