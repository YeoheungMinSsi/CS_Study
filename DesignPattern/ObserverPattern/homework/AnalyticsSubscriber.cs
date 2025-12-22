namespace ObserverPattern.homework;

public class AnalyticsSubscriber: IObserver
{
    private int _count = 0;
    public void Update(News news)
    {
        Console.WriteLine($"[통계 분석] {news.Title}를 분석하였습니다.");
        _count++;
        Console.WriteLine($"[통계 시스템] 현재까지 {_count}가지 뉴스를 분석하였습니다.");
    }
}