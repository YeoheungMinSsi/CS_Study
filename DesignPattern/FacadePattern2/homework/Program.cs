namespace FacadePattern2.homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==================================================");
            Console.WriteLine("클라이언트: 주문 시스템 퍼사드 객체를 생성합니다.");

            // 1. Facade 객체만 생성합니다.
            OrderFacade orderSystem = new OrderFacade(); 

            Console.WriteLine("\n--- 1차 주문 시도: 성공 예상 케이스 ---");
            
            // 2. 퍼사드의 단일 메서드만 호출합니다. (내부 순서에 대한 지식 없음)
            bool result1 = orderSystem.PlaceOrder("User_A", "키보드", 1, 800);
            
            Console.WriteLine($"\n클라이언트: 1차 주문 결과는 {(result1 ? "성공" : "실패")}입니다.");
            
            
            Console.WriteLine("\n--- 2차 주문 시도: 결제 실패 예상 케이스 ---");
            
            // 3. 내부 로직 변경 없이 단순히 매개변수만 바꿔 호출합니다. (결제 한도 1000원 초과)
            bool result2 = orderSystem.PlaceOrder("User_B", "모니터", 30, 15000000);
            
            Console.WriteLine($"\n클라이언트: 2차 주문 결과는 {(result2 ? "성공" : "실패")}입니다.");
            
            
            // *************************************************************************
            // * 퍼사드 패턴 준수 확인 (아래 코드는 절대 작성되어서는 안 됩니다!) *
            // *************************************************************************
            /* InventoryManager inventory = new InventoryManager(); // 개별 서비스 직접 접근 금지
            inventory.CheckStock("모니터", 1); // 개별 메서드 직접 호출 금지
            */
            
            Console.WriteLine("\n==================================================");
        }
    }
}