namespace CompositePattern2.homework;

public interface IMenuComponent
{
    public void Display(int indent);
    public void Add(IMenuComponent menuComponent);
    public void Remove(IMenuComponent menuComponent);
    List<IMenuComponent> FindByTag(string tag);
}