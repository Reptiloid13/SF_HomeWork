namespace Task1;

public class Exceptions
{

    public Exception[] ExceptionsArray { get; set; }



    public Exceptions()
    {
        InitArray();
    }

    private void InitArray()
    {
        ExceptionsArray = new Exception[5];

        ExceptionsArray[0] = new IndexOutOfRangeException();
        ExceptionsArray[1] = new UserNotFoundException();
        ExceptionsArray[2] = new FileNotFoundException();
        ExceptionsArray[3] = new DirectoryNotFoundException();
        ExceptionsArray[4] = new NotFiniteNumberException();
    }
}

internal class UserNotFoundException : Exception
{
    public UserNotFoundException() : base("User not found") { }
}