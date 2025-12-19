namespace FacadePattern2.homework;

public class DeliveryManager
{
    public void Initialize()
    {
        Console.WriteLine("DeliveryManager: 배송 시스템 연결 중...");
    }

    public void StartDelivery(string item)
    {
        Console.WriteLine($"DeliveryManager: 주문하신 상품 {item}이 출고되었습니다.");
    }
}