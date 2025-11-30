using System;
using System.Threading.Tasks;
using System.Collections.Generic; // 필요한 경우 추가

// 🌟 PaymentClient가 있는 네임스페이스와 동일하게 설정
namespace AdapterPattern.homework 
{
    public class Program // 🌟 Program 클래스도 이 네임스페이스 안에 있어야 합니다.
    {
        public static async Task Main(string[] args) 
        {
            Console.WriteLine("--- 결제 시스템 어댑터 패턴 테스트 시작 ---");
            
            // PaymentClient가 같은 네임스페이스에 있으므로 바로 호출 가능
            await PaymentClient.RunPaymentScenario(); 

            Console.WriteLine("--- 테스트 완료 ---");
        }
    }
}