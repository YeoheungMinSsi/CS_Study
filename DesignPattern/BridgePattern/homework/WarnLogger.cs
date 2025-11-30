namespace BridgePattern.homework;

public class WarnLogger:Logger
{
    public WarnLogger(ILogOutput output) : base(output)
    {
        
    }

    public override void Log(string message)
    {
        string msg = $"[WARN] {message}";
        _output.Write(msg);
    }
}