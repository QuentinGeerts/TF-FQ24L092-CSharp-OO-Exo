delegate void operationsDelegate(int a, double b);
delegate string operationsDelegate2(int a, double b);

delegate bool operationsDelegate3(int a);

class Program
{
    public static void Main(string[] args)
    {

        // Action
        // Idéal pour les méthodes qui ne retournent pas de valeur
        Action<double, double> operations = null;
        operationsDelegate operationsDelegate = null;


        // Func
        // Idéal pour les méthodes qui retournent une valeur

        Func<int, double, string> operations2 = null;

        // Predicate
        // Idéal pour les méthodes qui retournent un booléen

        Predicate<int> estPair = x => x % 2 == 0;
        //Predicate<Personne> estMajeur = p => p.Age >= 18;

        //Func<Personne, Personne, Personne[]> func = (p1, p2) => new Personne[] { p1, p2 };

    }
}