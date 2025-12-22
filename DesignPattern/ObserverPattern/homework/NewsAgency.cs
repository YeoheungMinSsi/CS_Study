namespace ObserverPattern.homework;

// Subject 설계(구현)
public class NewsAgency: ISubject
{
    public string Name { get; }

    // 구독자 관리 리스트
    private readonly List<IObserver> _observers = new List<IObserver>();

    public NewsAgency(string name)
    {
        Name = name;
    }
    
    public void AddObserver(IObserver o)
    {
        if(!_observers.Contains(o))  // 받은 인자값이 포함되지 않을 때
        {
            _observers.Add(o);  // 인자 값 추가
        }
        else
        {
            Console.WriteLine($"{o}가 이미 구독되어 있습니다.");
        }
    }

    public void RemoveObserver(IObserver o)
    {
        if (_observers.Contains(o))
        {
            _observers.Remove(o);
        }
        else
        {
            Console.WriteLine($"구독자 {o}가 없습니다.");
        }
    }

    // 뉴스 발생 메서드
    public void Publish(News news)
    {
        Console.WriteLine($"[{Name} 발행] {news.Title} ({news.Category})");
        NotifyObservers(news);
    }

    // 발행 시 호출 -> 발행 시 구독자에게 알림
    public void NotifyObservers(News payload)
    {
        foreach (var observer in _observers)
        {
            observer.Update(payload);
        }
    }
}