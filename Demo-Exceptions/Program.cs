using Demo_Exceptions;

try
{
    // int x = int.Parse(null); // Erreur: Value cannot be null. (Parameter 's')
    // int x = int.Parse("a"); // Erreur: The input string 'a' was not in a correct format.
    int x = int.Parse((long.MaxValue / 2).ToString()); // Overflow: Value was either too large or too small for an Int32.
}
catch (ArgumentNullException ex)
{
    Console.WriteLine($"ArgumentNull: {ex.Message}");
}
catch (FormatException ex)
{
    Console.WriteLine($"Format: {ex.Message}");
}
catch (OverflowException ex)
{
    Console.WriteLine($"Overflow: {ex.Message}");
}
catch (Exception ex)
{
    Console.WriteLine($"Erreur: {ex.Message}");
}

Console.WriteLine("Terminé!");

try
{
    int x = int.Parse((long.MaxValue / 2).ToString());
}
catch (Exception ex)
{
    // Pattern matching
    switch (ex)
    {
        case ArgumentNullException e:
            Console.WriteLine($"ArgumentNull: {e.GetType()} {e.Message}");
            break;

        case FormatException e:
            Console.WriteLine($"Format: {e.GetType()} {e.Message}");
            break;

        case OverflowException e:
            Console.WriteLine($"Overflow: {e.GetType()} {e.Message}");
            break;

        default:
            Console.WriteLine($"Erreur: {ex.GetType()} {ex.Message}");
            break;
    }
}

// Vous pouvez lever vos propres exceptions avec le mot-clef "throw"

try
{
    throw new Exception("Une erreur s'est produite");
}
catch (Exception e)
{
    Console.WriteLine($"Erreur: {e.Message}");
}

// Vous pouvez créer vos propres exceptions en héritant de la classe Exception ou de ses enfants

try
{
    throw new MyCustomException("Message personnalisé pour mon exception");
}
catch (Exception ex)
{
    Console.WriteLine($"Erreur: {ex.GetType()} - {ex.Message}");
}