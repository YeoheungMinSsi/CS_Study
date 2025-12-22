namespace ObserverPattern.homework;

public class AppSubscriber: IObserver
{
    public void Update(News news)
    {
        Console.WriteLine($"[App push] 새 뉴스 발행: {news.Title}.");
    }
}