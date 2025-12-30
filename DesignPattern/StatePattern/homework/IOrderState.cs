namespace StatePattern.homework;

// State 부분
public interface IOrderState
{
    void ProcessPayment(Order order, bool isSuccess);  // 결제
    void CancelOrder(Order order);  // 취소
    void VerifyOrder(Order order);  // 검증
    void ShipOrder(Order order);  // 배송
    void Delivery(Order order);  // 배달
    void ReturnOrder(Order order);  // 반품
    void RefundOrder(Order order);  // 환불
    void CompleteOrder(Order order);  // 완료
}