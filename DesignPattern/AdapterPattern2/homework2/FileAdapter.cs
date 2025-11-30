namespace AdapterPattern2.homework2;

public class FileAdapter: ILogger
{
    private readonly FileLogger _fileLogger;

    public FileAdapter(FileLogger fileLogger)
    {
        _fileLogger = fileLogger;
    }

    public void Log(string message)
    {
        Console.WriteLine($"[FileAdapter] FileLogger 변환 후 호출");
        _fileLogger.Save(message);
        Console.WriteLine();

    }
}