namespace MementoPattern2.homework;

public class Program
{
    public static void Main(string[] args)
    {
        DesignEditor editor = new DesignEditor();
        HistoryManager history = new HistoryManager();

        // 2. 요소 추가 및 첫 번째 상태 저장 (초기 상태)
        // 요구사항: id, x, y, width, height, color
        editor.AddElement(new DesignElement("rect", new Position(0, 0), new Size(100, 50), "blue"));
        history.Push(editor.CreateSnapShot());
        Console.WriteLine("--- 초기 상태 저장 완료 ---");

        // 3. 요소 이동 및 두 번째 상태 저장
        editor.MoveElement("rect", 50, 0); // (0,0) -> (50,0)
        history.Push(editor.CreateSnapShot());
        Console.WriteLine("--- 이동 후 상태 저장 완료 ---");

        // 4. 색상 변경 (현재 상태, 아직 저장 안 함)
        editor.ChangeColor("rect", "red");
        
        Console.WriteLine("\n[현재 에디터 상태]");
        editor.GetContent(); // 색상: red, 위치: (50, 0)

        // 5. Restore 수행 (JS의 pop() 동작을 Undo 메서드로 대체)
        Console.WriteLine("\n--- Undo 실행 (가장 최근 저장 시점으로 복원) ---");
        history.Undo(editor);
        
        Console.WriteLine("\n[Undo 후 에디터 상태]");
        Console.WriteLine(editor.GetContent()); // 색상: blue, 위치: (50, 0)으로 복구되어야 함

        // 6. 추가 테스트: 한 번 더 Undo 수행
        Console.WriteLine("\n--- Undo 한 번 더 실행 (초기 시점으로 복원) ---");
        history.Undo(editor);
        
        Console.WriteLine("\n[두 번째 Undo 후 에디터 상태]");
        Console.WriteLine(editor.GetContent()); // 색상: blue, 위치: (0, 0)
    }
}