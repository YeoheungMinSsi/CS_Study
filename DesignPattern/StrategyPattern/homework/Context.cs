namespace StrategyPattern.homework;

public class Context
{
    private ICompressionStrategy _strategy;
    
    public Context(ICompressionStrategy strategy)
    {
        _strategy = strategy;
    }
    
    public void SetStrategy(ICompressionStrategy strategy)
    {
        // 전략 변경
        _strategy = strategy;
    }
    
    public void Upload(string fileName)
    {
        Console.WriteLine($"[시스템] {fileName} 업로드 시작...");
        _strategy.Compress(fileName);
        Console.WriteLine($"[시스템] {fileName} 업로드 완료!");
    }
}