namespace StrategyPattern2.homework;

public class DijkstraStrategy: IPathfindingStrategy
{
    public void FindPath(string start, string destination, string mapData)
    {
        Console.WriteLine($"[Dijkstra 알고리즘] 가중치 기반 경로 탐색을 시작합니다.");
        Console.WriteLine($"[Dijkstra 알고리즘] {mapData}지형에서 {start} -> {destination}로 이동 시 최소 비용으로 이동합니다.");
        Console.WriteLine("[Dijkstra 알고리즘] 특징: 모든 노드의 비용을 계산하여 가중치가 있는 맵에서 최단/최안전 경로를 보장");
    }
}