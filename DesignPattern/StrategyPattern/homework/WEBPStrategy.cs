namespace StrategyPattern.homework;

public class WEBPStrategy: ICompressionStrategy
{
    public void Compress(string fileName)
    {
        Console.WriteLine($"[WEBP] {fileName}을 최신 웹 표준 방식으로 고효육 압축합니다.");
    }
}