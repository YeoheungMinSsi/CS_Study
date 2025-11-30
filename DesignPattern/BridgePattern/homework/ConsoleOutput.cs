namespace BridgePattern.homework;

public class ConsoleOutput: ILogOutput
{
    public void Write(string log)
    {
        Console.WriteLine($"콘솔 출력: {log}");
        Console.WriteLine();
    }
}