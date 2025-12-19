namespace ChainResponsibilityPattern2.homework;

public class FinalFilter: BaseFilter
{
    private const string FilterWord = "FinalFilter"; 
    
    public override bool Check(string message)
    {
        Console.WriteLine($"[{FilterWord}]: Passed & Cleared");
        // 마지막 filter는 끝을 냄
        return false;
    }
}