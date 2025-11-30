namespace CompositePattern.homework;

public interface INode
{
    // 요구사항 1
    string Render();
    
    // 요구사항 1-2
    void AddChild(INode node);
    void RemoveChild(INode node);
}