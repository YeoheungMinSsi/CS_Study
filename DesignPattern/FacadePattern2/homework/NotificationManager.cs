namespace FacadePattern2.homework;

public class NotificationManager
{
    public void Initialize()
    {
        Console.WriteLine("NotificationManager: 알림 시스템 연결 중(SMS, 이메일)...");
    }

    public void SendOrderConfirmation(string orderId, string customerId)
    {
        Console.WriteLine($"NotificationManager: >> {customerId}님께 주문({orderId}) 성공 알림 전송 완료");
    }

    public void SendFailureNotification(string reason)
    {
        Console.WriteLine($"NotificationManager: >> [고객알림] 주문 실패 안내 전송, 원인 : {reason}");
    }
}