namespace ChainResponsibilityPattern2.homework;

public class Program
{
    public static void Main(string[] args)
    {
        var keyword = new KeywordFilter();
        var link = new LinkFilter();
        var attachment = new AttachmentFilter();
        var final = new FinalFilter();
        
        keyword.SetNext(link).SetNext(attachment).SetNext(final);

        keyword.Check("광고 당첨 링크 클릭!");
        keyword.Check("아래 링크를 클릭해 주세요 \n https://....");
        keyword.Check("첨부파일 클릭!");

    }
}