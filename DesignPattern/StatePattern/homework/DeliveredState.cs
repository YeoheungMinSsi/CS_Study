namespace StatePattern.homework;

public class DeliveredState: IOrderState
{
    public void ProcessPayment(Order order, bool isSuccess) => Console.WriteLine("[오류] 이미 결제가 완료되었습니다.");
    public void CancelOrder(Order order) => Console.WriteLine("[오류] 배달 중인 주문은 취소가 불가능합니다.");
    public void VerifyOrder(Order order) => Console.WriteLine("[오류] 검증이 완료된 주문입니다.");
    public void ShipOrder(Order order) => Console.WriteLine("[오류] 배송을 완료한 주문입니다.");
    public void Delivery(Order order)
    {
        Console.WriteLine("[상품 배달 중] 현재 물품이 배달 중입니다. 도착까지 N일 남았습니다.");
        order.SetState(new CompletedState());
        
    } 
    public void RefundOrder(Order order) => Console.WriteLine("[오류] 배달 중인 주문은 환불이 불가능합니다.");
    public void ReturnOrder(Order order) => Console.WriteLine("[오류] 배달이 완료되지 않은 주문은 반품이 불가능합니다.");
    public void CompleteOrder(Order order) => Console.WriteLine("[오류] 아직 완료되지 않은 주문입니다.");
}