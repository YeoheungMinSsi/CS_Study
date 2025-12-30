namespace ObserverPattern2.homework;

public class LogWidget: IObserver
{
    public void Update(SystemMetrics data)
    {
        // DataTime.Now를 사용하여 변경 시각 기록
        Console.WriteLine($"[로그 - {DateTime.Now:HH:mm:ss}] CPU: {data.Cpu}%, Memory: {data.Memory}%, Network: {data.Network}mbps");
    }
}