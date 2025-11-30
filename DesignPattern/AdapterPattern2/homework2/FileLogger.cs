namespace AdapterPattern2.homework2;

public class FileLogger
{
    public void Save(string message)
    {
        Console.WriteLine($"[FILE LOG] App.log에 {message} 저장됨");
    }
}