namespace AdapterPattern2.homework2;

public class ConsoleAdapter: ILogger
{
    private readonly ConsoleLogger _consoleLogger;

    public ConsoleAdapter(ConsoleLogger consoleLogger)
    {
        _consoleLogger = consoleLogger;
    }

    public void Log(string message)
    {
        Console.WriteLine($"[ConsoleAdapter] ConsoleLogger 변환 후 호출");
        _consoleLogger.Write(message);
        Console.WriteLine();

    }
}