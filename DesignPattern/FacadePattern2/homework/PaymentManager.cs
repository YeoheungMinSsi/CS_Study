namespace FacadePattern2.homework;

public class PaymentManager
{
    private bool _isConnected = false;
    
    public void Initialize()
    {
        _isConnected = true;
        if (_isConnected)
        {
            Console.WriteLine("PaymentManager: 외부 결제 시스템에 연결되었습니다.");
        }
        else
        {
            Console.WriteLine("PaymentManager: 외부 결제 시스템 연결에 실패하였습니다.");
        }
    }

    public bool ProcessPayment(int amount)
    {
        if (!_isConnected)
        {
            Console.WriteLine("PaymentManager: [경고] 시스템 연결 오류로 결제 처리를 할 수 없습니다.");
            return false;
        }

        Console.WriteLine($"PaymentManager: {amount}원 결제 승인 요청 중...");
            
        if (amount <= 1000)
        {
            Console.WriteLine("PaymentManager: 결제 성공적으로 승인됨.");
            return true;
        }
        else
        {
            Console.WriteLine("PaymentManager: [경고] 결제 금액 초과(1000원 초과)로 승인 실패!");
            return false;
        }
    }
}