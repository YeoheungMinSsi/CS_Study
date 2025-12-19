namespace IteratorPattern2.homework;

public class File: IFileSystemNode
{
    private string _name;

    public File(string name)
    {
        _name = name;
    }

    public bool IsDirectory()
    {
        // 디렉토리가 아니라는 의미로 False 반환
        return false;
    }

    public string GetName()
    {
        return _name;
    }
}