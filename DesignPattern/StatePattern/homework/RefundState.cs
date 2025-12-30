namespace StatePattern.homework;

public class RefundState: IOrderState
{
    public void ProcessPayment(Order order, bool isSuccess) => Console.WriteLine("[오류] 환불 중인 주문입니다.");
    public void CancelOrder(Order order) => Console.WriteLine("[오류] 환불 중인 주문입니다.");
    public void VerifyOrder(Order order) => Console.WriteLine("[오류] 환불 중인 주문입니다.");
    public void ShipOrder(Order order) => Console.WriteLine("[오류] 환불 중인 주문입니다.");
    public void Delivery(Order order) => Console.WriteLine("[오류] 환불 중인 주문입니다.");
    
    public void RefundOrder(Order order)
    {
        Console.WriteLine("[오류] 환불을 진행하고 있습니다.");
        // 환불 상태를 전달하면 환불 완료라는 메시지가 나오도록 if-else 진행
        order.SetState(new CompletedState());
    }
    
    public void ReturnOrder(Order order) => Console.WriteLine("[오류] 환불 중인 주문입니다.");
    public void CompleteOrder(Order order) => Console.WriteLine("[오류] 환불 중인 주문입니다.");
}