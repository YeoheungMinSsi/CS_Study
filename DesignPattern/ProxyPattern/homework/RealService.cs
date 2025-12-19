using System;
using System.Threading.Tasks;
using System.Transactions;

namespace ProxyPattern.homework;

public class RealService: IService
{
    private static readonly Random _random = new Random(); 
    
    public async Task<string> FetchData(int id)    {
        Console.WriteLine($"[RealService] Fetching data for id={id}...");
        
        // 랜덤 지연 시간 추가
        int delayTime = _random.Next(500, 1001);

        // Task.Delay를 통해서 비동기적으로 지연
        await Task.Delay(delayTime);
        
        Console.WriteLine($"[RealTime] Data for id={id}, fetched after {delayTime}ms");

        return $"Data content for ID: {id} (Fetched at {DateTime.Now:HH:mm:ss.fff})";
    }
}