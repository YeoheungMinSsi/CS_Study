namespace ObserverPattern2.homework;

public class Program
{
    public static void Main(string[] args)
    {
        var collector = new DataCollector();

        var alert = new AlertWidget();
        var graph = new GraphWidget();
        var log = new LogWidget();
        
        // 사용할 구독자 추가
        collector.AddObserver(alert);
        collector.AddObserver(graph);
        collector.AddObserver(log);
        
        Console.WriteLine("----- 실시간 실시간 모니터링 시작 -----");

        collector.SetMetrics(new SystemMetrics(30.5, 45.2, 120.0));

        // 시나리오 2: 메모리 사용량 상승 (경보 임계치 85 미만)
        collector.SetMetrics(new SystemMetrics(45.0, 70.8, 150.5));

        // 시나리오 3: CPU 부하 발생 (임계치 80 초과 -> AlertWidget 반응)
        collector.SetMetrics(new SystemMetrics(92.3, 75.0, 200.1));

        // 5. 구독 취소 테스트 (그래프 위젯 제거)
        Console.WriteLine("\n[System] 그래프 위젯 구독을 취소합니다.");
        collector.RemoveObserver(graph);

        // 시나리오 4: 메모리 과부하 발생 (임계치 85 초과 -> AlertWidget 반응)
        // 그래프 위젯은 제거되었으므로 더 이상 출력되지 않습니다.
        collector.SetMetrics(new SystemMetrics(50.0, 88.5, 180.2));

        Console.WriteLine("\n=== 모니터링 종료 ===");
    }
}