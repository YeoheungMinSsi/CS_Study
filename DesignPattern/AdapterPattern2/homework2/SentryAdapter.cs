namespace AdapterPattern2.homework2;

public class SentryAdapter: ILogger
{
    private readonly SentryLogger _sentryLogger;

    public SentryAdapter(SentryLogger sentryLogger)
    {
        _sentryLogger = sentryLogger;
    }

    public void Log(string message)
    {
        Console.WriteLine("[SentryAdapter] SentryLogger 변환 후 호출");
        _sentryLogger.Send(message);
        Console.WriteLine();

    }
}