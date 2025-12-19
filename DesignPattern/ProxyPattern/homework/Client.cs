using System;
using System.Threading.Tasks;

namespace ProxyPattern.homework;

public class Client
{
    public static async Task Main(string[] args)
    {
        Console.WriteLine("------프록시 패턴 테스트------\n");
        // 본체 인스턴스 생성
        IService realService = new RealService();

        // 프록시 인스턴스 생성 시 본체를 주입
        IService service = new CachingProxy(new RealService());
        
        // Console.WriteLine("\n[1차 호출] ID 101 요청 (캐시 부재 예상");
        // Console.WriteLine("-----------------------------------------------");
        
        // await service.fetchData(101); // 캐시 없음 → 실제 호출
        string result1 = await service.FetchData(101);
        Console.WriteLine($"[Client] Result 1: {result1}");
        
        // Console.WriteLine("\n[2차 호출] ID 101 요청 (캐시 존재 예상");
        // Console.WriteLine("-----------------------------------------------");
        
        // await service.fetchData(101); // 캐시 있음 → 캐시 반환
        string result2 = await service.FetchData(101); // 캐시 있음 → 캐시 반환
        Console.WriteLine($"[Client] Result 2: {result2}");
        
        Console.WriteLine("------프록시 패턴 테스트 완료------");
    }
}