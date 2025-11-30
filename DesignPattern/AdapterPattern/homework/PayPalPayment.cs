using System;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace AdapterPattern.homework
{
    public class PayPalPayment
    {
        public void makePayment(string email, int amount)
        {
            Console.WriteLine($"PayPal: {email}에게 ${amount} 결제 요청 처리됨.");
        }
    }
}