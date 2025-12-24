namespace StrategyPattern.homework;

public class PNGStrategy: ICompressionStrategy
{
    public void Compress(string fileName)
    {
        Console.WriteLine($"[PNG] {fileName}을 무손실 압축하여 투명도를 유지합니다.");
    }
}