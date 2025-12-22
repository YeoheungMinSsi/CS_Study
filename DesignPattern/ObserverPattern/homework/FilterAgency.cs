namespace ObserverPattern.homework;

public class FilterAgency: IObserver
{
    private readonly NewsCategory _interest;

    public FilterAgency(NewsCategory interest)
    {
        _interest = interest;
    }
    
    public void Update(News news)
    {
        // 관심있는 카테고리가 있다면 출력 출력
        if ((news.Category & _interest) != 0)
        {
            Console.WriteLine($"[뉴스 알림] 관심 카테고리-{news.Category} | 뉴스 발행: {news.Title}");
        }
    }
    
}