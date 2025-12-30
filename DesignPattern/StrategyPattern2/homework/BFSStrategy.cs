namespace StrategyPattern2.homework;

public class BFSStrategy: IPathfindingStrategy
{
    public void FindPath(string start, string destination, string mapData)
    {
        Console.WriteLine($"[BFS 알고리즘] 인접 구역을 순차적으로 탐색합니다.");
        Console.WriteLine($"[BFS 알고리즘] {mapData}의 모든 인접 노드를 순차적으로 확인하여 {start} -> {destination}경로를 찾습니다.");
        Console.WriteLine("[BFS 알고리즘] 특징: 가중치가 없는 단순 지형에서 최소 단계의 경로를 찾는 데 적합");
    }
}