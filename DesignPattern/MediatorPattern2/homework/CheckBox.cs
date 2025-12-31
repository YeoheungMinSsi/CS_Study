namespace MediatorPattern2.homework;

public class CheckBox: Component
{
    public bool IsChecked { get; set; }


    public CheckBox(IFormMediator mediator, string id) : base(mediator, id) { }
}