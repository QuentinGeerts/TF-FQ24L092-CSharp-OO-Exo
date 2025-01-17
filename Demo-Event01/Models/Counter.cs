namespace Demo_Event01.Models;

// Définition du délégué pour typer l'événement
public delegate void ValueChanged();

public class Counter
{
    private int _total;
    private int _threshold;

    public Counter(int threshold)
    {
        _threshold = threshold;
    }

    // Définition de l'événement
    public event ValueChanged ThresholdReachedEvent; // Seule la classe Counter peut déclencher l'événement
    //public ValueChanged ThresholdReached; // Attention, n'importe quelle classe peut déclencher le délégué

    public void Add(int value)
    {
        _total += value;
        Console.WriteLine($"La valeur totale actuelle vaut : {_total}");

        // Déclenchement de l'événement lorsqu'on atteint le seuil
        if (_total >= _threshold)
        {
            OnThresholdReached();
        }
    }

    protected virtual void OnThresholdReached ()
    {
        ThresholdReachedEvent?.Invoke();
    }

}
