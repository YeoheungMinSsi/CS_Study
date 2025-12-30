namespace StatePattern.homework;

public class PaidState: IOrderState
{
    public void ProcessPayment(Order order, bool isSuccess) => Console.WriteLine("[오류] 이미 결제가 완료되었습니다.");
    public void CancelOrder(Order order)
    {
        Console.WriteLine("[결제 취소] 완료된 결제를 취소합니다, 환불 절차를 진행합니다.");
        order.SetState(new RefundState());
    }

    public void VerifyOrder(Order order)
    {
        Console.WriteLine("[주문 확인] 주문 내용 검증 및 재고를 확보합니다.");
        Console.WriteLine("[검증 완료] 주문 내용 검증 및 재고 확보를 완료하였습니다.");  // 추후 상태로 if-else문으로 분기
        order.SetState(new ShippedState());
    }
    
    public void ShipOrder(Order order) => Console.WriteLine("[오류] 검증 중인 주문입니다.");
    public void Delivery(Order order) => Console.WriteLine("[오류] 배송이 시작되지 않은 주문입니다.");
    
    public void RefundOrder(Order order)
    {
        Console.WriteLine("[오류] 배송 전 환불을 진행합니다..");
        order.SetState(new RefundState());
    }
    
    public void ReturnOrder(Order order) => Console.WriteLine("[오류] 배송이 완료되지 않은 주문입니다.");
    public void CompleteOrder(Order order) => Console.WriteLine("[오류] 아직 완료되지 않은 주문입니다.");
}