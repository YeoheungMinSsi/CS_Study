using System.ComponentModel;

namespace IteratorPattern2.homework;

public class Directory: IFileSystemNode
{
    private List<IFileSystemNode> _children = new List<IFileSystemNode>();
    private readonly string _name;

    public Directory(string name)
    {
        _name = name + "/";
    }
    
    public void Add(IFileSystemNode node)
    {
        _children.Add(node);
    }

    public List<IFileSystemNode> GetChildren()
    {
        return _children;  // 내부 요소에 접근할 수 있도록 Getter 요소
    }
        
    public bool IsDirectory()
    {
        return true;
    }

    public string GetName()
    {
        return _name;
    }
}