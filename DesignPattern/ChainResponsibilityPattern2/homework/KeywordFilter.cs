namespace ChainResponsibilityPattern2.homework;

public class KeywordFilter: BaseFilter
{
    private readonly List<string> _keywordList = ["광고", "당첨", "여론조사"];
    private const string FilterWord = "KeywordFilter"; 
    
    public override bool Check(string message)
    {
        foreach (var keyword in _keywordList)
        {
            if (message.Contains(keyword))
            {
                Console.WriteLine($"[{FilterWord}] Blocked keywords: {keyword} \n => Message classified as SPAM");
                return true;
            }
        }
        Console.WriteLine($"[{FilterWord}]: Passed");
        // 만약 return false로 끝낸다면 바로 끝을 냄 -> 책임 연쇄가 아님
        return base.Check(message);
    }
}