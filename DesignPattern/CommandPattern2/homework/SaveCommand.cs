namespace CommandPattern2.homework;

public class SaveCommand: ICommand
{
    private readonly Receiver _receiver;
    public string Name => "Save";

    public SaveCommand(Receiver receiver)
    {
        _receiver = receiver;
    }
        
        
    public void Execute()
    {
        Console.WriteLine("[Command] Executing SaveCommand");
        _receiver.Save();
    }
}