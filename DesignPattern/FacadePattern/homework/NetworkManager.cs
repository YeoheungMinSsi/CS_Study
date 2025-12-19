namespace FacadePattern.homework;

public class NetworkManager
{
    public void Connect()
    {
        Console.WriteLine("NetworkManager: 네트워크 연결 시작...");
    }

    public void SendData(string data)
    {
        Console.WriteLine($"NetworkManager: 데이터 전송 {data} 전송 완료");
    }
}