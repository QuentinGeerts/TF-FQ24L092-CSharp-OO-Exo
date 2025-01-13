namespace Demo_Exceptions;

internal class MyCustomException : Exception
{
    public MyCustomException()
    {
    }

    public MyCustomException(string? message) : base(message)
    {
    }
}
