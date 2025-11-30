using System;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace BridgePattern2.homework;

public class JSONExporter : IReportExporter
{
    public void ExportData(string title, List<object> data)
    {
        Console.WriteLine($"[JSON Exporter] JSON 형식으로 변환 및 출력: {title}");
        Console.WriteLine($"  - JSON 객체 {data.Count}개 생성됨");
    }
}