namespace StrategyPattern2.homework;

public interface IPathfindingStrategy
{
    void FindPath(string start, string destination, string mapData);
}