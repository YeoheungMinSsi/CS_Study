namespace FacadePattern.homework;

public class ChatManager
{
    public void Initialize()
    {
        Console.WriteLine("ChatManager: 실시간 채팅 서버 연결 중...");
    }

    public void ShowWelcomeMassage(string massage)
    {
        Console.WriteLine($"ChatManager: {massage}");
    }
}