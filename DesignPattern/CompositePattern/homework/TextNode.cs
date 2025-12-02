namespace CompositePattern.homework;

// note: 순수 텍스트를 표현
public class TextNode: INode
{
    // 텍스트의 불변성 추가
    private readonly string _text;

    public TextNode(string text)
    {
        _text = text;
    }

    public void AddChild(INode node)
    {
        throw new NotSupportedException("TextNode는 자식 노드를 가질 수 없습니다.");
    }
    public void RemoveChild(INode node)
    {
        throw new NotSupportedException("TextNode는 자식 노드를 제거할 수 없습니다.");
    }
    
    public string Render()
    {
        return this._text;
    }

    public string ToJson()
    {
        return this.Render();
    }
}