namespace ChainResponsibility.homework;

public class LoggingHandler: BaseHandler
{
    public override void Handle(Request requset)
    {
        Console.WriteLine("[Logging] Logging request...");
        base.Handle(requset);
    }
}