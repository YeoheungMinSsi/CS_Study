using System;
using System.Collections.Generic;

namespace IteratorPattern.homework;

public interface IIterator<T>
{
    bool HasNext();
    T Next();
}