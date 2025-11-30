namespace BridgePattern.homework;

public class SlackOutput: ILogOutput
{
    public void Write(string log)
    {
        Console.Write($"Slack 추가: {log}");
        Console.WriteLine();
    }
}