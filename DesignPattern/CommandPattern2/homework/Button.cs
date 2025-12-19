namespace CommandPattern2.homework;

public class Button
{
    private readonly ICommand _command;

    public Button(ICommand command)
    {
        _command = command;
    }

    public void Click()
    {
        Console.WriteLine($"[Button] {_command.Name} clicked");
        _command.Execute();
    }
}