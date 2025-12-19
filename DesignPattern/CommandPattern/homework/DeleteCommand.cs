using System.Text;

namespace CommandPattern.homework;

public class DeleteCommand: ICommand
{
    private readonly Receiver _receiver;
    private readonly int _count;
    private readonly StringBuilder _text = new StringBuilder();  // 백업본
    
    public DeleteCommand(Receiver receiver, int count)
    {
        _receiver = receiver;
        _count = count;
    }

    public void Execute()
    {
        Console.WriteLine($"[Command] Deleted: \"{_text}\"의 마지막 {_count}자리 문자열 삭제");
        
        string currentContent = _receiver.GetContent();  // 문자열 가지고오기
        int actualContent = Math.Min(_count, currentContent.Length);  // _count의 최솟값 계산하기 -> count가 커도 문자열 최개값으로 설정
        
        // 삭제되 내용 백업 -> subString으로 뽑아내기(n자리부터 m까지 글자 뽑아내기)
        _text.Clear();
        _text.Append(currentContent.Substring(currentContent.Length - _count, _count));
        
        _receiver.Delete(actualContent);  // 문자열 삭제하기
    }

    public void Undo()
    {
        Console.WriteLine($"[Undo] Restored: \"{_text}\"");
        _receiver.Insert(_text.ToString());
    }
}