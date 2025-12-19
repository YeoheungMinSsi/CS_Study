namespace CommandPattern.homework;

public class Program
{
    public static void Main(string[] args)
    {
        Receiver editor = new Receiver();
        EditorApp app = new EditorApp();
        
        // Hello 문자열 삽입 명렁 실행
        app.Execute(new InsertCommand(editor, "Hello"));
        // World 문자열 삽입 명령 실행
        app.Execute(new InsertCommand(editor, "World!"));
        
        // Undo 명령 실행
        app.Undo();
        
        editor.PrintState();
    }
}