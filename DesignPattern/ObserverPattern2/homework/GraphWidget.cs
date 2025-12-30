namespace ObserverPattern2.homework;

// 데이터  집계 후 차트용 포맷으로 변환/렌더 시뮬레이션
public class GraphWidget: IObserver
{
    public void Update(SystemMetrics data)
    {
        Console.WriteLine($"[그래픽 포맷/랜더링] 시각화 처리중... [CPU: {new string('|', (int)(data.Cpu / 10))}]");
    }
}