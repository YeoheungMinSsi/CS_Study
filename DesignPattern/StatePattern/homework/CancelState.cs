namespace StatePattern.homework;

public class CancelState: IOrderState
{
    public void ProcessPayment(Order order, bool isSuccess) => Console.WriteLine("[오류] 결제를 취소한 주문입니다.");
    public void CancelOrder(Order order) => Console.WriteLine("[오류] 결제를 취소한 주문입니다.");
    public void VerifyOrder(Order order) => Console.WriteLine("[오류] 결제를 취소한 주문입니다.");
    public void ShipOrder(Order order) => Console.WriteLine("[오류] 결제를 취소한 주문입니다.");
    public void Delivery(Order order) => Console.WriteLine("[오류] 아직 배송 전인 주문입니다."); 
    public void RefundOrder(Order order) => Console.WriteLine("[오류] 결제를 취소한 주문입니다.");
    public void ReturnOrder(Order order) => Console.WriteLine("[오류] 결제를 취소한 주문입니다.");
    public void CompleteOrder(Order order) => Console.WriteLine("[결제 취소] 결제가 완전히 취소되었습니다.");

}