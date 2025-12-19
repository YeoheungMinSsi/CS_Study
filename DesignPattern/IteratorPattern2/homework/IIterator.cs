using System;
using System.Collections.Generic;

namespace IteratorPattern2.homework;

public interface IIterator<T>
{
    bool HasNext();
    T Next();
}