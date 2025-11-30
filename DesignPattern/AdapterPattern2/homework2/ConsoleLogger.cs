namespace AdapterPattern2.homework2;

public class ConsoleLogger
{
    public void Write(string message)
    {
        Console.WriteLine($"[CONSOLE LOG] {message}");
    }
    
}