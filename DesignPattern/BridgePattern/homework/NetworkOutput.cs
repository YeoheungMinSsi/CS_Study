namespace BridgePattern.homework;

public class NetworkOutput: ILogOutput
{
    public void Write(string log)
    {
        Console.WriteLine($"네트워크 연결: {log}");
        Console.WriteLine();
    }

}