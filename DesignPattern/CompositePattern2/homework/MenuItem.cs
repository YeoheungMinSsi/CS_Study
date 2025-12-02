namespace CompositePattern2.homework;

public class MenuItem: IMenuComponent
{
    private readonly string _name;
    
    public MenuItem(string name)
    {
        _name = name;
    }
    
    public void Display(int indent)
    {
        string indentStr = new string(' ', indent*2);  // 들여쓰기
        Console.WriteLine($"{indentStr}|- {this._name}");
    }
    public void Add(IMenuComponent menuComponent)
    {
        throw new NotSupportedException("MenuItem 노드는 하위 메뉴를 가질 수 없음");
    }
    public void Remove(IMenuComponent menuComponent)
    {
        throw new NotSupportedException("MenuItem 노드는 하위 메뉴가 없어 삭제 불가능");   
    }

    public List<IMenuComponent> FindByTag(string tag)
    {
        // throw new NotImplementedException("MenuItem 노드는 하위 메뉴가 없어 하위 tag가 없음");
        return new List<IMenuComponent>();
    }
}