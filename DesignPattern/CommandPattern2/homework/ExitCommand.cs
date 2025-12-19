namespace CommandPattern2.homework;

public class ExitCommand: ICommand
{
    private readonly Receiver _receiver;
    public string Name => "Exit";

    
    public ExitCommand(Receiver receiver)
    {
        _receiver = receiver;
    }
        
        
    public void Execute()
    {
        Console.WriteLine("[Command] Executing ExitCommand");
        _receiver.Exit();
    }
}