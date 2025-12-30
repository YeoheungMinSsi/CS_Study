namespace StrategyPattern2.homework;

public class Navigation
{
    private IPathfindingStrategy _strategy;

    public Navigation(IPathfindingStrategy strategy)
    {
        _strategy = strategy;
    }

    public void SetStrategy(IPathfindingStrategy strategy)
    {
        _strategy = strategy;
        Console.WriteLine($"[시스템] 탐색 알고리즘 변경 - {_strategy.GetType().Name}");
    }

    public void Navigate(string start, string target, string map)
    {
        Console.WriteLine($"[시스템] 경로 탐색: {start}에서 {target}까지 경로 탐색을 시작합니다.");
        _strategy.FindPath(start, target, map);
    }
}