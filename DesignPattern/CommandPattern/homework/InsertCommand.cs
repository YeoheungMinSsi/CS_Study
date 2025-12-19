using System.Text;

namespace CommandPattern.homework;

public class InsertCommand: ICommand
{
    private readonly Receiver _receiver;
    private readonly StringBuilder _text = new StringBuilder();
    
    public InsertCommand(Receiver receiver, string text)
    {
        _receiver = receiver;
        _text.Append(text);
    }

    public void Execute()
    {
        Console.WriteLine($"[Command] Added: \"{_text}\"");
        _receiver.Insert(_text.ToString());
    }

    public void Undo()
    {
        Console.WriteLine($"[Undo] Removed: \"{_text}\"");
        _receiver.Delete(_text.Length);
    }
}