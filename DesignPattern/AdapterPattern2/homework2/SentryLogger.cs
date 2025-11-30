namespace AdapterPattern2.homework2;

public class SentryLogger
{
    public void Send(string message)
    {
        Console.WriteLine($"[SENTRY LOG]: {message}를 외부 서비스로 전송하였습니다.");
    }
}