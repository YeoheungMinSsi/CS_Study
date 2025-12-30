namespace StatePattern.homework;

public class Program
{
    public static void Main(string[] args)
    {
        Order newOrder = new Order(new CreatedState());
        
        newOrder.ProcessPayment(true);  // CreatedState -> PaymentPendingState
        // 여기서 ProcessPayment를 한번더 수행하지 않으면 PaymentPending에서 멈춤
        newOrder.ProcessPayment(true);  // PaymentPendingState -> PaidState
        newOrder.VerifyOrder();  // PaidState -> ShippedState
        newOrder.ShipOrder();  // ShippedState -> DeliveredState
        newOrder.Delivery();  // DeliveredState -> CompletedState
        newOrder.CompleteOrder();  // finish
        
        Console.WriteLine("\n==== 환불 시나리오 테스트=====");

        Order refundOrder = new Order(new CreatedState());
        refundOrder.ProcessPayment(true);
        
        refundOrder.CancelOrder();
        refundOrder.RefundOrder();

    }
}