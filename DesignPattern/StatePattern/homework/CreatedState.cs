namespace StatePattern.homework;

public class CreatedState: IOrderState
{
    public void ProcessPayment(Order order, bool isSuccess)
    {
        Console.WriteLine("[결제 요청] 결제 시도 중...");
        order.SetState(new PaymentPendingState());
        
    }

    public void CancelOrder(Order order)
    {
        Console.WriteLine("[결제 취소] 결제 요청 전 주문을 취소합니다.");
        order.SetState(new CancelState());
    }

    public void VerifyOrder(Order order) => Console.WriteLine("[오류] 결제 전 주문은 검증할 수 없습니다.");
    public void ShipOrder(Order order) => Console.WriteLine("[오류] 결제가 완료되지 않은 주문은 배송할 수 없습니다.");
    public void Delivery(Order order) => Console.WriteLine("[오류] 아직 배송 전인 주문입니다."); 
    public void RefundOrder(Order order) => Console.WriteLine("[오류] 결제되지 않은 주문은 반품할 수 없습니다.");
    public void ReturnOrder(Order order) => Console.WriteLine("[오류] 결제되지 않은 주문은 환불할 수 없습니다.");
    public void CompleteOrder(Order order) => Console.WriteLine("[오류] 아직 완료되지 않은 주문입니다.");
}