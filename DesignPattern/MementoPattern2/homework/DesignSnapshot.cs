namespace MementoPattern2.homework;

public class DesignSnapshot
{
    private List<DesignElement> _elements = new List<DesignElement>();

    public DesignSnapshot(IEnumerable<DesignElement> elements)
    {
        _elements = new List<DesignElement>(elements);
    }

    public List<DesignElement> GetState()
    {
        // 반환 시 새로운 리스트에 담아 반환하여 원본 훼손 방지
        return new List<DesignElement>(_elements);
    }
}