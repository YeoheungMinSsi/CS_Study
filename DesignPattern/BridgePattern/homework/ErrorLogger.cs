namespace BridgePattern.homework;

public class ErrorLogger: Logger
{
    // 부모(Logger) 생성자를 호출(base)하여 ILogOutPut을 전달
    public ErrorLogger(ILogOutput output) : base(output)
    {
        
    }

    public override void Log(string message)
    {
        string msg = $"[ERROR] {message}";
        _output.Write(msg);
    }
}