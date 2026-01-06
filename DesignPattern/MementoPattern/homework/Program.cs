namespace MementoPattern.homework;

public class Program
{
    public static void Main(string[] args)
    {
        // var editor = new Editor();
        // var history = new History();
        //
        // editor.SetContent("Hello");
        // history.Push(editor.CreateMemento());
        //
        // editor.SetContent("Hello World");
        // history.Push(editor.CreateMemento());
        //
        // editor.SetContent("Hello World!!!");
        //
        // Console.WriteLine(editor.GetContent()); // Hello World!!!
        //
        // editor.Restore(history.Pop());
        // Console.WriteLine(editor.GetContent()); // Hello World
        
        
        Editor editor = new Editor();
        History history = new History();

        // 1. 첫 번째 상태 저장
        editor.SetContent("Hello");
        history.Push(editor.CreateMemento());

        // 2. 두 번째 상태 저장
        editor.SetContent("Hello World");
        history.Push(editor.CreateMemento());

        // 3. 현재 상태 (저장하지 않음)
        editor.SetContent("Hello World!!!");

        Console.WriteLine("\n--- Undo 실행 ---");
        // 4. Undo 실행 (Hello World!!! -> Hello World)
        history.Undo(editor);

        // 5. Undo 한 번 더 실행 (Hello World -> Hello)
        Console.WriteLine("--- Undo 한 번 더 실행 ---"); // Hello
        history.Undo(editor);

        Console.WriteLine("\n--- Redo 실행 ---");
        // 6. Redo 실행 (Hello -> Hello World)
        history.Redo(editor);

        
        // 7. Redo 한 번 더 실행 (Hello World -> Hello World!!!)
        Console.WriteLine("--- Redo 한 번 더 실행 ---"); // Hello World
        history.Redo(editor);
        
    }
}