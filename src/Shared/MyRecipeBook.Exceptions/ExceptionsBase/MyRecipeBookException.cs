namespace MyRecipeBook.Exceptions.ExceptionsBase;

public abstract class MyRecipeBookException : System.Exception
{
    public MyRecipeBookException(string message) : base(message)
    {
    }

    public abstract int StatusCode { get; }

    public abstract List<string> GetErrors();
}