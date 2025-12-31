namespace MediatorPattern2.homework;

public class Button: Component
{
    public bool Enabled { get; set; } = false;


    public Button(IFormMediator mediator, string id) : base(mediator, id) { }
}