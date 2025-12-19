namespace ChainResponsibilityPattern2.homework;

public class BaseFilter: ISpamFilter
{
    private ISpamFilter _nextFilter;
    public ISpamFilter SetNext(ISpamFilter spamFilter)
    {
        this._nextFilter = spamFilter;
        return spamFilter;
    }
    
    public virtual bool Check(string message)
    {
        // _nextFilter?.Check(message);  // 다음 필터가 있다면 Check 메서드 실행
        // return false;  // 내용이 무엇이든 무조건 false 반환 -> 문제
        if (_nextFilter != null)
        {
            // _nextFilter가 비어있지 않다면 다음 필터의 Check 행동 수행
            return _nextFilter.Check(message);
        }
        // 다음 필터가 비어있다면 -> 모든 필터에 스팸 존재 하지않음
        // false(스팸아님) 반환
        return false;
    }
}