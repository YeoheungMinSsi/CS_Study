using System;
using System.Threading.Tasks;

namespace ProxyPattern.homework;

public class CachingProxy : IService
{
    //실제 서비스가 수행하는 것 처럼 테스트 -> 서비스 실행 -> 캐시 저장
    private readonly IService _realService;
    private readonly Dictionary<int, string> _cache = new Dictionary<int, string>();

    public CachingProxy(IService realService)
    {
        _realService = realService;
    }
    
    public async Task<string> FetchData(int id)
    {
        //  이미 캐시가 있는지 확인
        if (_cache.ContainsKey(id))
        {
            // 이미_cache안에 id를 가지고 있는 캐시가 존재함
            Console.WriteLine($"[CacheProxy] Returning cached data for id={id}");
            return _cache[id];
        }
        else
        {
            Console.WriteLine($"[CacheProxy] Cache miss, Calling ReadService for id={id}");
            string data = await _realService.FetchData(id);
            
            _cache.Add(id, data);
            
            Console.WriteLine($"[CacheProxy] Data for id={id} stored in cache.");
            return data;
        }
    }  
}