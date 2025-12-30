namespace StatePattern.homework;

// Order 부분
public class Order
{
    private IOrderState _state;  // 현재 상태를 인터페이스 타입으로 보유

    public Order(IOrderState state)
    {
        _state = state;
    }
    
    // 상태 교체 메서드
    public void SetState(IOrderState state)
    {
        _state = state;  // 새로운 order를 만드는 것이 아닌 상태만 교체함
    }

    // 이벤트 기반 전이 구조
    public void ProcessPayment(bool isSuccess) => _state.ProcessPayment(this, isSuccess);  // 현재 상태에게 '결제' 로직을 위임함
    public void VerifyOrder() => _state.VerifyOrder(this);
    public void ShipOrder() => _state.ShipOrder(this);
    public void Delivery() => _state.Delivery(this);
    public void ReturnOrder() => _state.ReturnOrder(this);
    public void CancelOrder() => _state.CancelOrder(this);
    public void RefundOrder() => _state.RefundOrder(this);
    public void CompleteOrder() => _state.CompleteOrder(this);
}