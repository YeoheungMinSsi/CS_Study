namespace MementoPattern.homework;

public class History
{
    private Stack<EditorMemento> _undoStack = new Stack<EditorMemento>();
    private Stack<EditorMemento> _redoStack = new Stack<EditorMemento>();
    
    public void Push(EditorMemento memento)
    {
        _undoStack.Push(memento);
        _redoStack.Clear();  // Push를 하면 이전작업이 없어지니 Clear
    }

    public EditorMemento Pop()
    {
        if (_undoStack.Count > 0)
        {
            return _undoStack.Pop();
        }
        return null;
    }
    
    public void Undo(Editor editor)
    {
        if (_undoStack.Count > 0)
        {
            // 현재 상태(현재 그 상태, 이전상태X)를 redo 스택에 저장
            _redoStack.Push(editor.CreateMemento());

            var memento = _undoStack.Pop();
            editor.Restore(memento);
        }
    }

    public void Redo(Editor editor)
    {
        if (_redoStack.Count > 0)
        {
            // 현재 상태 저장
            _undoStack.Push(editor.CreateMemento());

            var memento = _redoStack.Pop();
            editor.Restore(memento);
        }
    }
}