namespace ObserverPattern.homework;

public interface ISubject
{
    string Name { get; }
    void AddObserver(IObserver o);
    void RemoveObserver(IObserver o);
    void NotifyObservers(News payload);
}