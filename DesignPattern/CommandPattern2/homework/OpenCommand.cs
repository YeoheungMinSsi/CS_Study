namespace CommandPattern2.homework;

public class OpenCommand: ICommand
{
    private readonly Receiver _receiver;
    public string Name => "Open";

    
    public OpenCommand(Receiver receiver)
    {
        _receiver = receiver;
    }
        
        
    public void Execute()
    {
        Console.WriteLine("[Command] Executing OpenCommand");
        _receiver.Open();
    }
}