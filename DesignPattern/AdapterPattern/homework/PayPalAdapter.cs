using System;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace AdapterPattern.homework
{
    public class PayPalAdapter : IPaymentAdapter
    {
        private readonly PayPalPayment _paypalPayment;

        public PayPalAdapter(PayPalPayment paypalPayment)
        {
            _paypalPayment = paypalPayment;
        }

        public async Task<PaymentResult> Pay(Payload payload)
        {
            Console.WriteLine("PayPalAdapter: PayPal 형식으로 Payload 변환 중...");

            string email = payload.email;
            int amount = payload.amount;
        
            _paypalPayment.makePayment(email, amount);

            return new PaymentResult(
                success: true,
                amount: payload.amount,
                paymentAt: DateTime.Now,
                paymentId: $"PayPal_ID_{Guid.NewGuid().ToString().Substring(0, 8)}"
            );
        }
    }
}

