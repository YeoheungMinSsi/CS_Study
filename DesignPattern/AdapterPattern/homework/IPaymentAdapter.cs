using System;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace AdapterPattern.homework
{
    public interface IPaymentAdapter
    {
        // 비동기 메서드 Task<T> - 비동기로 PaymentResult를 반환
        Task<PaymentResult> Pay(Payload payload);
    }
}