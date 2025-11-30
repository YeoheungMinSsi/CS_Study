namespace BridgePattern.homework;

public class DebugLogger: Logger
{
    public DebugLogger(ILogOutput output) : base(output)
    {
        
    }

    public override void Log(string message)
    {
        string msg = $"[DEBUG] {message}";
        _output.Write(msg);
    }
}