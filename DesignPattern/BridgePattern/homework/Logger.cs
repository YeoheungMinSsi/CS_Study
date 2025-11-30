using System;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace BridgePattern.homework;

public abstract class Logger
{
    // LogOutPut 타입을 구성 요소를 받아서 위임하기 위한 필드
    protected ILogOutput _output;
    
    // 생성자
    public Logger(ILogOutput output)
    {
        _output = output;
    }

    public ILogOutput OutputImple
    {
        get { return _output; }
        set
        {
            if(value == null)
                throw new ArgumentNullException("Output is Null");
            _output = value;
        }
    }
    
    public abstract void Log(string message);
}