namespace MediatorPattern2.homework;

public interface IFormMediator
{
    void Notify(Component sender, string e);
}