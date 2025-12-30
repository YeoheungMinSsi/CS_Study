namespace ObserverPattern2.homework;

public class DataCollector: ISubject
{
    private List<IObserver> _observers = new List<IObserver>();
    private SystemMetrics _metrics;  // 현재 데이터 상태 보유
    
    public void AddObserver(IObserver o)
    {
        if (!_observers.Contains(o))
        {
            _observers.Add(o);
        }
        else
        {
            Console.WriteLine($"이미 {o} 구독자가 존재합니다.");
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
            Console.WriteLine($"{o} 구독자가 존재하지 않습니다.");
        }
    }

    // 데이터 업데이트 시 -> 구독자들에게 전송
    public void NotifyObserver()
    {
        foreach (var observer in _observers)
        {
            observer.Update(_metrics);
        }
    }

    // 현재 상태(지표) 반환
    public SystemMetrics GetMetrics()
    {
        Console.WriteLine("현제 데이터 수신중...");
        return _metrics;
    }

    // 지표 업데이트 -> 상태 업데이트 및 알림(Notify 호출)
    public void SetMetrics(SystemMetrics metrics)
    {
        this._metrics = metrics;
        Console.WriteLine("\n[System] 지표가 업데이트되었습니다.");
        NotifyObserver();
    }
}