using System;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace AdapterPattern.homework
{
    public record PaymentResult(
        bool success,
        int amount,
        DateTime paymentAt,
        string paymentId
    );
}