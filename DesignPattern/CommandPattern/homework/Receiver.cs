using System;
using System.Text;

namespace CommandPattern.homework;

public class Receiver
{
    private const string Word = "Editor"; 
    private StringBuilder _content = new StringBuilder();        

    public void Insert(string text)
    {
        _content.Append(text);
    }

    public void Delete(int count)
    {
        // count길이가 _content 길이보다 크면 0으로 만들기 위해 content 길이만큼 제거
        if (count > _content.Length) count = _content.Length;
        // content 길이에서 count만큼의 길이를 삭제해, count 반환
        _content.Remove(_content.Length - count, count);
    }

    public string GetContent()
    {
        return _content.ToString();
    }

    public void PrintState()
    {
        Console.WriteLine($"[{Word}] Current Text: \"{_content}\"");
    }
}