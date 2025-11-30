using System;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace AdapterPattern.homework
{
    public class StripePayment
    {
        public void charge(int total)
        {
            Console.WriteLine($"Stripe: {total}이 충전되었습니다.");
        }
    }
}