using System;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace AdapterPattern.homework
{
    public record Payload(
        int amount,
        string email,
        string phone
    );
}