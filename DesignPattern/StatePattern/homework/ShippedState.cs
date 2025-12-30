namespace StatePattern.homework;

public class ShippedState: IOrderState
{
    public void ProcessPayment(Order order, bool isSuccess) => Console.WriteLine("[오류] 이미 결제가 완료되었습니다.");
    public void CancelOrder(Order order) => Console.WriteLine("[오류] 배송 중인 주문은 취소가 불가능합니다.");
    public void VerifyOrder(Order order) => Console.WriteLine("[오류] 검증이 완료된 주문입니다.");
    public void ShipOrder(Order order)
    { 
        Console.WriteLine("[배송 진행] 제품 배송이 시작되었습니다.");
        order.SetState(new DeliveredState());
    }
    public void Delivery(Order order) => Console.WriteLine("[오류] 아직 배송 전인 주문입니다."); 
    public void RefundOrder(Order order) => Console.WriteLine("[오류] 배송 중인 주문은 환불이 불가능합니다.");
    public void ReturnOrder(Order order) => Console.WriteLine("[오류] 배송이 완료되지 않은 주문은 반품이 불가능합니다.");
    public void CompleteOrder(Order order) => Console.WriteLine("[오류] 아직 완료되지 않은 주문입니다.");
}