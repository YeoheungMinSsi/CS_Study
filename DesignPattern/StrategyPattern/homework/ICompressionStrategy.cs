namespace StrategyPattern.homework;

public interface ICompressionStrategy
{
    // 각 환경에서 압축 방식을 구현하기 위한 매서드
    void Compress(string fileName);
}