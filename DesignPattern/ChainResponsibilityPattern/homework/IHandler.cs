namespace ChainResponsibility.homework;

public interface IHandler
{
    IHandler SetNext(IHandler handler);
    void Handle(Request request);
}