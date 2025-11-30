using System;
using System.Collections.Generic;


namespace BridgePattern2.homework;

public class CSVExporter : IReportExporter
{
    public void ExportData(string title, List<object> data)
    {
        Console.WriteLine($"[CSV Exporter] CSV로 출력: {title}");
        Console.WriteLine($"  - 데이터 항목 수: {data.Count}개");
    }
}