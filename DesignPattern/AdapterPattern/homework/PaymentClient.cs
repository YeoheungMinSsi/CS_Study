using System;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace AdapterPattern.homework
{
    public class PaymentClient
    {
        public static async Task RunPaymentScenario()
        {
            var testPayload = new Payload(
                amount: 1000,
                email: "korea@korea.co.kr",
                phone: "010-0000-0000"
            );
        
            Console.WriteLine("------1. Stripe 결제를 IPaymentAdapter 인터페이스로 실행----\n");
        
            // 1. Stripe 인터페이스 생성
            IPaymentAdapter stripePayment = new StripeAdapter(new StripePayment());
            // 2. 공통된 Pay 메서드 호출
            PaymentResult stripeResult = await stripePayment.Pay(testPayload);
            // 3. 결과 출력
            Console.WriteLine($"[클라이언트 확인] Stripe 결제 ID: {stripeResult.paymentId}, 성공여부: {stripeResult.success}\n");
        
            Console.WriteLine("------1. payPal 결제를 IPaymentAdapter 인터페이스로 실행----\n");
            
            // 2. PayPal 인터페이스 생성
            IPaymentAdapter paypalPayment = new PayPalAdapter(new PayPalPayment());
            PaymentResult paypalResult = await paypalPayment.Pay(testPayload);
            Console.WriteLine($"[클라이언트 확인] Stripe 결제 ID: {paypalResult.paymentId}, 성공여부: {paypalResult.success}\n");

            Console.WriteLine("=== 3. 여러 어댑터를 하나의 리스트로 처리 ===\n");
            
            // IPaymentAdapter 리스트를 생성하여 모든 결제 시스템을 동일하게 다룰 수 있습니다.
            var adapters = new List<IPaymentAdapter>
            {
                new StripeAdapter(new StripePayment()),
                new PayPalAdapter(new PayPalPayment())
            };

            foreach (var adapter in adapters)
            {
                Console.WriteLine($"[반복문] {adapter.GetType().Name} 실행 중...");
                PaymentResult result = await adapter.Pay(testPayload with { amount = 5000 }); // 금액을 변경하여 테스트
                Console.WriteLine($"[반복문] 결제 ID: {result.paymentId}, 금액: {result.amount}\n");
            }
        }
    }
}

