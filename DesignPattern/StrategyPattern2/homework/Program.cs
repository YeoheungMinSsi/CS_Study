namespace StrategyPattern2.homework;

public class Program
{
    public static void Main(string[] args)
    {
        Navigation navi = new Navigation(new BFSStrategy());
        
        Console.WriteLine("아파트 단지 택지 배달");
        navi.Navigate("1동", "8동", "롯데 캐슬");
        
        Console.WriteLine("다음 지역 이동");
        navi.SetStrategy(new DijkstraStrategy());
        navi.Navigate("사상구", "부산진구", "부산 도로");
        
        Console.WriteLine("공사 중 지역");
        navi.SetStrategy(new AStarStrategy());
        navi.Navigate("공사 지역 입구", "공사 지역 출구", "공사 도로");
    }
}