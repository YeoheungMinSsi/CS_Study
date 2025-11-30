namespace BridgePattern2.homework;

public class PDFExporter : IReportExporter
{
    public void ExportData(string title, List<object> data)
    {
        Console.WriteLine($"[PDF Exporter] PDF로 출력: {title}");
        Console.WriteLine($"  - 데이터 항목 수: {data.Count}개");
    }
}