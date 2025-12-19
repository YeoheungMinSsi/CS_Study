namespace ChainResponsibilityPattern2.homework;

public class AttachmentFilter: BaseFilter
{
    private readonly List<string> _keywordList = ["attachment", "첨부파일"];
    private const string FilterWord = "AttachmentFilter"; 
    
    public override bool Check(string message)
    {
        foreach (var keyword in _keywordList)
        {
            string lowerMessage = message.ToLower();
            
            if (lowerMessage.Contains(keyword))
            {
                Console.WriteLine($"[{FilterWord}] Blocked attachment \n => Message classified as SPAM");
                return true;
            }
        }
        Console.WriteLine($"[{FilterWord}]: Passed");
        // 만약 return false로 끝낸다면 바로 끝을 냄 -> 책임 연쇄가 아님
        return base.Check(message);
    }
}