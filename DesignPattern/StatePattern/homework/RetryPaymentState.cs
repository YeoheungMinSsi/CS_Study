namespace StatePattern.homework;

public class RetryPaymentState: IOrderState
{
    public void ProcessPayment(Order order, bool isSuccess)
    { 
        Console.WriteLine("[결제 확인 중] 결제 시스템으로부터 응답을 확인 중...");
        if (isSuccess)
        {
            Console.WriteLine("[결제 완료] 결제 완료가 완료 되었습니다.");    
            order.SetState(new PaidState());
        }
        else
        {
            Console.WriteLine("[결제 실패] 결제가 거절되었습니다. 결제를 다시 진행하겠습니다.");
            order.SetState(new RetryPaymentState());
        }
    }
    
    public void CancelOrder(Order order)
    {
        Console.WriteLine("[결제 취소] 결제 진행 중 결제를 취소합니다.");
        order.SetState(new CancelState());
    }
    
    public void VerifyOrder(Order order) => Console.WriteLine("[오류] 결제를 취소한 주문입니다.");
    public void ShipOrder(Order order) => Console.WriteLine("[오류] 결제를 취소한 주문입니다.");
    public void Delivery(Order order) => Console.WriteLine("[오류] 결제를 취소한 주문입니다.");
    public void RefundOrder(Order order) => Console.WriteLine("[오류] 결제를 취소한 주문입니다.");
    public void ReturnOrder(Order order) => Console.WriteLine("[오류] 결제를 취소한 주문입니다.");
    public void CompleteOrder(Order order) => Console.WriteLine("[오류] 아직 완료되지 않은 주문입니다.");
}