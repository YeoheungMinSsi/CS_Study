namespace BridgePattern.homework;

public class InfoLogger: Logger
{
    public InfoLogger(ILogOutput output) : base(output)
    {
        
    }

    public override void Log(string message)
    {
        string msg = $"[INFO] {message}";
        _output.Write(msg);
    }
}