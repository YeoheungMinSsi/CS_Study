namespace MediatorPattern.homework;

public class User
{
    public string Name { get; }
    private IChatMediator _mediator;

    public User(string name, IChatMediator mediator)
    {
        Name = name;
        _mediator = mediator;
    }
    
    public void Send(string message)
    {
        _mediator.SendMessage(message, this);
    }

    public void Receive(string message, string from)
    {
        Console.WriteLine($"{Name}이(가) {from}으로부터 메시지 수신: {message}");
    }
}