namespace Carwash02.Models;

public class Voiture
{
    public Voiture(string plaque)
    {
        Plaque = plaque;
    }

    public string Plaque { get; set; }
}
