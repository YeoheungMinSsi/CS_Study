namespace FacadePattern2.homework;

public class OrderFacade
{
    private InventoryManager _inventoryManager;
    private PaymentManager _paymentManager;
    private DeliveryManager _deliveryManager;
    private NotificationManager _notificationManager;

    public OrderFacade()
    {
        this._inventoryManager = new InventoryManager();
        this._paymentManager = new PaymentManager();
        this._deliveryManager = new DeliveryManager();
        this._notificationManager = new NotificationManager();
        
        Console.WriteLine("--------- OrderFacade: 주문 서비스 초기화 시작 ---------");
        this._inventoryManager.Initialize();
        this._paymentManager.Initialize();
        this._deliveryManager.Initialize();
        this._notificationManager.Initialize();
        Console.WriteLine("--------- OrderFacade: 주문 서비스 초기화 완료 ---------");
    }

    public bool PlaceOrder(string customerId, string item, int quantity, int price)
    {
        // 주문 ID 생성 (예시)
        // Guid.NewGuid() -> 유일함을 보장하는 128비트 표준 식별자 구조체, NewGuid()로 새 인스턴스 생성
        // 생성한 식별자를 문자열로 8자리만 잘라서 입력
        string orderId = Guid.NewGuid().ToString().Substring(0, 8);
            
        Console.WriteLine($"\n=============================================");
        Console.WriteLine($"OrderFacade: 주문 처리 시작 (ID: {orderId}, 금액: {price}원)");
        Console.WriteLine($"=============================================");

        // 1단계: 재고 확인
        // 하위 시스템의 결과를 받아 다음 단계 실행 여부를 결정합니다.
        if (!_inventoryManager.CheckStock(item, quantity))
        {
            // 실패 시: 알림 전송 후 즉시 종료
            _notificationManager.SendFailureNotification("재고 부족");
            return false;
        }

        // 2단계: 결제 처리 (재고가 충분할 때만 실행)
        if (!_paymentManager.ProcessPayment(price))
        {
            // 실패 시: 알림 전송 후 즉시 종료
            _notificationManager.SendFailureNotification("결제 실패");
            return false;
        }

        // 3단계: 배송 시작 및 알림 (재고와 결제가 모두 성공했을 때만 실행)
        _deliveryManager.StartDelivery(item);
        _notificationManager.SendOrderConfirmation(orderId, customerId);

        Console.WriteLine($"=============================================");
        Console.WriteLine($"OrderFacade: 주문 처리 성공적으로 완료. 주문 ID: {orderId}");
        Console.WriteLine($"=============================================");
        return true;
    }
}