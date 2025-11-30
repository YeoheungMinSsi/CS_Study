namespace BridgePattern.homework;

public class FileOutput: ILogOutput
{
    public void Write(string log)
    {
        Console.WriteLine($"파일에 저장: {log}");
        Console.WriteLine();
    }
}