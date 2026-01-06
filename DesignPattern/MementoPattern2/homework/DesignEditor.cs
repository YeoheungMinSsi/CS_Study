namespace MementoPattern2.homework;

public class DesignEditor
{
    private List<DesignElement> _elements = new List<DesignElement>();

    public void AddElement(DesignElement element)
    {
        _elements.Add(element);
        Console.WriteLine($"[Editor] {element.ToString()} added");
    }
    
    public void MoveElement(string id, double dx, double dy)
    {
        // 입력한 id와 동일한 index가 있는지 확인하여 해당 요소를 찾음
        var index = _elements.FindIndex(e => e.Id == id);
        
        // 인덱스가 있을 시
        if (index != -1)
        {
            // 인덱스가 -1가 아닐때 index를 통해서 _elements 리스트에 존재하는 element를 차증ㅁ
            var el = _elements[index];
            
            // record의  with 키워드로 위치가 변경된 새 객체 생성(기존 x, y에 dx, dy를 더함)
            _elements[index] = el with
            {
                Position = new Position(el.Position.X + dx, el.Position.Y + dy)
            };
            Console.WriteLine($"[Editor] {id} moved to ({_elements[index].Position.X}, {_elements[index].Position.Y})");
        }
    }

    public void ChangeColor(string id, string color)
    {
        var index = _elements.FindIndex(e => e.Id == id);

        // index에 해당하는 color 색을 변경
        if (index != -1)
        {
            var el = _elements[index];
            _elements[index] = el with { Color = color };
            Console.WriteLine($"[Editor] {id} changed to ({_elements[index].Color})");
        }
    }
    
    public DesignSnapshot CreateSnapShot()
    {
        // 현재 리스트를 그대로 넘기며 DesignSnapShot 생성자에서 복사본을 만듦
        return new DesignSnapshot(_elements);
    }
    
    public void Restore(DesignSnapshot snapshot)
    {
        if (snapshot != null)
        {
            // 스냅샷이 가지고 있는 리스트를 다시 현재 에디터의 리스트로 가지고 옮
            _elements = snapshot.GetState();
        }
    }

    public string GetContent()
    {
        if (_elements == null || _elements.Count == 0)
        {
            return "에디터가 비어 있습니다.";
        }

        // 각 요소의 ToString() 결과를 줄바꿈(\n)으로 연결하여 하나의 문자열로 만듭니다.
        return string.Join("\n", _elements.Select(e => e.ToString()));
    }
    
}