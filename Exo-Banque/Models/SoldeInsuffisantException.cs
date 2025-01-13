namespace Exo_Banque.Models;

internal class SoldeInsuffisantException : Exception
{
    public SoldeInsuffisantException() : this("Solde insuffisant")
    {
    }

    public SoldeInsuffisantException(string? message) : base(message)
    {
    }
}
