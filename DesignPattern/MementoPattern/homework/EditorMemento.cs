namespace MementoPattern.homework;

public class EditorMemento
{
    private readonly string _content;

    public EditorMemento(string content)
    {
        _content = content;
    }

    public string Content => _content;
}