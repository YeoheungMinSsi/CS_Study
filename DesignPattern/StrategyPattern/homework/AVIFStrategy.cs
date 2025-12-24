namespace StrategyPattern.homework;

public class AVIFStrategy: ICompressionStrategy
{
    public void Compress(string fileName)
    {
        Console.WriteLine($"[AVIF] {fileName}을 최고효율으로 압축합니다.");

    }
}