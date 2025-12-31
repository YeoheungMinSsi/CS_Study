namespace MediatorPattern2.homework;

public abstract class Component
{
    protected IFormMediator _mediator;
    public string Id { get; }

    public Component(IFormMediator mediator, string id)
    {
        _mediator = mediator;
        this.Id = id;
    }

    public void Charged(string eventName)
    {
        this._mediator.Notify(this, eventName);
    }
}