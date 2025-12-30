namespace StrategyPattern2.homework;

public class AStarStrategy: IPathfindingStrategy
{
    public void FindPath(string start, string destination, string mapData)
    {
        Console.WriteLine($"[A* 알고리즘] 휴리스틱 기반 경로 탐색을 시작합니다.");
        Console.WriteLine($"[A* 알고리즘] {mapData}지형에서 {start} -> {destination}로 이동하는 최적의 경로를 탐색");
        Console.WriteLine($"[A* 알고리즘] 특징: 휴리스틱 함수를 사용하여 탐색 시간을 단축하고 효율적인 경로를 찾습니다. ");
    }
}