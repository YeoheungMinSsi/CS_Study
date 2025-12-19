namespace IteratorPattern2.homework;

public class DirectoryIterator: IIterator<IFileSystemNode>
{
    private Stack<IFileSystemNode> _stack = new Stack<IFileSystemNode>();

    public DirectoryIterator(IFileSystemNode root)
    {
        // 생성자 시점에는 처음을 표시해야 함으로 root로 설정
        _stack.Push(root);
    }

    public bool HasNext()
    {
        return _stack.Count > 0;  // stack이 다음을 가지고 있는가
    }

    public IFileSystemNode Next()
    {
        if (!HasNext()) // 다음을 가지고 있지 않다면
        {
            throw new InvalidOperationException("더 이상 노드가 없습니다.");
        }

        // 현재 노드 하나를 stack에서 꺼내기 위함
        IFileSystemNode currentNode = _stack.Pop();
        if (currentNode is Directory directory)
        {
            // Directory의 자식 노드들을 가지고옴 -> 스택에 넣기 위함
            List<IFileSystemNode> children = directory.GetChildren();

            // 반복문을 역순으로 넣어야 출력 시 원래 순서대로 나옴
            for (int i = children.Count - 1; i >= 0; i--)
            {
                _stack.Push(children[i]);
            }
        }

        return currentNode;
    }
}