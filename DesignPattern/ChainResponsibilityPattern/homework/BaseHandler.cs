namespace ChainResponsibility.homework;

public abstract class BaseHandler : IHandler
{
    private IHandler _nextHandler;

    public IHandler SetNext(IHandler handler)
    {
        _nextHandler = handler;
        return handler;
    }

    public virtual void Handle(Request request)
    {
        // ?를 통해서 nextHandler가 null이 아니라면 실행으로 표현
        _nextHandler?.Handle(request);
    }
}