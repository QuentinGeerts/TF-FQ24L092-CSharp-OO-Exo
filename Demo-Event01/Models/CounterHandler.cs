namespace Demo_Event01.Models;

public class CounterHandler
{
    private Counter _counter;
    private AdvancedCounter _advancedCounter;

    public CounterHandler(int threshold)
    {
        _counter = new Counter(threshold);
        _counter.ThresholdReachedEvent += OnCounterThresholdReached;

        //_counter.ThresholdReachedEvent?.Invoke(); // Seule la classe qui déclare l'événement PEUT déclencher l'événement
        //_counter.ThresholdReached?.Invoke(); // N'importe quelle classe peut déclencher l'événement dans le cas où c'est une juste une variable

        _advancedCounter = new AdvancedCounter(threshold);
        _advancedCounter.ThresholdReachedEvent += OnAdvancedCounterThresholReached;
    }

    public void AddToCounter(int value)
    {
        _counter.Add(value);
    }

    public void AddToAdvancedCounter(int value)
    {
        _advancedCounter.Add(value);
    }

    private void OnCounterThresholdReached()
    {
        Console.WriteLine("CounterHandler : Le seuil a été atteint pour Counter !");
    }

    private void OnAdvancedCounterThresholReached()
    {
        Console.WriteLine("CounterHandler : Le seuil a été atteint pour AdvancedCounter !");
    }

}
