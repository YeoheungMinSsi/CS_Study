namespace MementoPattern.homework;

public class Editor
{
    private string _content = "";

    public void SetContent(string text)
    {
        _content = text;
        Console.WriteLine($"[Editor] 상태 저장: \"{_content}\"");
    }

    public EditorMemento CreateMemento()
    {
        return new EditorMemento(_content);
    }

    public void Restore(EditorMemento memento)
    {
        if (memento != null)
        {
            _content = memento.Content;
        }
        Console.WriteLine($"[Editor] 복원완료: \"{_content}\"");
    }

    public string GetContent()
    {
        return _content;
    }
}