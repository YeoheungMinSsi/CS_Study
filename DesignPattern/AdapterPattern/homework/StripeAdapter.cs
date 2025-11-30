using System;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace AdapterPattern.homework
{
    public class StripeAdapter : IPaymentAdapter
    {
    
        private readonly StripePayment _stripePayment;

        public StripeAdapter(StripePayment stripePayment)
        {
            _stripePayment = stripePayment;
        }


        public async Task<PaymentResult> Pay(Payload payload)
        {
            Console.WriteLine("StripeAdapter: Stripe 형식으로 Payload 변환 중...");
        
            // 입력데이터 변환
            int total = payload.amount;

            _stripePayment.charge(total);

            return new PaymentResult(
                success: true,
                amount: payload.amount,
                paymentAt: DateTime.Now,
                paymentId: $"Stripe_ID_{Guid.NewGuid().ToString().Substring(0, 8)}"
            );

        }
    }
}