namespace ObserverPattern2.homework;

public interface ISubject
{
    void AddObserver(IObserver o);
    void RemoveObserver(IObserver o);
    void NotifyObserver();
}