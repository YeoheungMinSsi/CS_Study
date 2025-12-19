using System;
using System.Threading.Tasks;

namespace ProxyPattern.homework;

public interface IService
{
    Task<string> FetchData(int id);
}