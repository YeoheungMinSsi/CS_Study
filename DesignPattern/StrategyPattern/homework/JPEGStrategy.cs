namespace StrategyPattern.homework;

public class JPEGStrategy: ICompressionStrategy
{
    public void Compress(string fileName)
    {
        Console.WriteLine($"[JPEG] {fileName}을 손실 압축하여 용량을 최소화합니다.");
    }
}