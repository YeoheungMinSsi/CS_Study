namespace ChainResponsibility.homework;

public class ControllerHandler: BaseHandler
{
    public override void Handle(Request request)
    {
        Console.WriteLine("[Controller] Request ok");
        base.Handle(request);
    }
}