using System;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace BridgePattern.homework;

public interface ILogOutput
{
    void Write(string log);
}