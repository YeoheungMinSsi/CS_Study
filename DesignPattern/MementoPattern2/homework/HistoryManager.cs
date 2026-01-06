namespace MementoPattern2.homework;

public class HistoryManager
{
    // DesignElement는 여러 요소가 있읜 하나의 개체에 요소 전체가 있는 Snapshot을 사용
    private Stack<DesignSnapshot> _undoStack = new Stack<DesignSnapshot>();
    private Stack<DesignSnapshot> _redoStack = new Stack<DesignSnapshot>();

    public void Push(DesignSnapshot snapshot)
    {
        _undoStack.Push(snapshot);
        _redoStack.Clear();
    }

    public void Undo(DesignEditor editor)
    {
        if (_undoStack.Count > 0)
        {
            _redoStack.Push(editor.CreateSnapShot());

            // Undo에 마지막 요소를 꺼내 에디터(restore)에 전달 -> 에디터는 최근 요소를 가지고 있음
            var snapShot = _undoStack.Pop();
            editor.Restore(snapShot);

            Console.WriteLine($"[History] Undo -> Restored previous design state");
        }
        else
        {
            Console.WriteLine($"[History] Undo -> No previous design state to restore");
        }
    }

    public void Redo(DesignEditor editor)
    {
        if (_redoStack.Count > 0)
        {
            _undoStack.Push(editor.CreateSnapShot());

            var snapShot = _redoStack.Pop();
            editor.Restore(snapShot);

            Console.WriteLine($"[History] Redo -> Restored previous design state");
        }
        else
        {
            Console.WriteLine($"[History] Redo -> No previous design state to restore");
        }
    }
    
}