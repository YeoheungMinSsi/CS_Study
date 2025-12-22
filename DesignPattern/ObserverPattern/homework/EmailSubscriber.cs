namespace ObserverPattern.homework;

public class EmailSubscriber: IObserver
{
    public void Update(News news)
    {
        Console.WriteLine($"[Email] '{news.Title}' 뉴스를 이메일로 전송하였습니다.");
    }
}