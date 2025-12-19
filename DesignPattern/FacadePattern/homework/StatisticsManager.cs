namespace FacadePattern.homework;

public class StatisticsManager
{
    public void Initialize()
    {
        Console.WriteLine("StatisticsManager: 통계 집계 중...");
    }

    public void ReportGameResult(int score)
    {
        Console.WriteLine($"StatisticsManager: 게임 결과 = {score}점");
    }
}