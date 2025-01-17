namespace Demo_Event01.Models;

public class AdvancedCounter : Counter
{
    public AdvancedCounter(int threshold) : base(threshold)
    {
    }

    protected override void OnThresholdReached()
    {
        Console.WriteLine($"AdvancedCounter : Seuil atteint avec des fonctionnalités supplémentaires");
        // Possible de déclencher l'événement depuis la classe fille avec une méthode redéfinie
        base.OnThresholdReached(); // Appel de la méthode de la classe mère (donc exécution de l'événement par la classe mère)
    }
}
