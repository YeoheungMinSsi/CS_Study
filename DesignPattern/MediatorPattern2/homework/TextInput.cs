namespace MediatorPattern2.homework;

public class TextInput: Component
{
    public string Text { get; set; } = "";
    
    public TextInput(IFormMediator mediator, string id) : base(mediator, id) { }
}