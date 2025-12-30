namespace ObserverPattern2.homework;

public class AlertWidget: IObserver
{
    public void Update(SystemMetrics data)
    {
        if (data.Cpu > 80 || data.Memory > 85)
        {
            Console.WriteLine("[시스템 경보] 현재 시스템 상태가 위험합니다.");
            Console.WriteLine($"현재 CPU 사용률이 {data.Cpu}, 메모리 사용률이 {data.Memory} 입니다.");
        }
    }
}