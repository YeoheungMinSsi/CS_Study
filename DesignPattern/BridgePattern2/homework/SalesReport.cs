using System.Collections.Generic;
using System;

namespace BridgePattern2.homework;

public class SalesReport : Report
{
    // 임시 데이터 (실제 데이터 대신 목업 데이터 사용)
    private List<object> _salesData = new List<object> { "Item A: 10000원", "Item B: 25000원" };
    private const string REPORT_TITLE = "매출 리포트";

    public SalesReport(IReportExporter exporter) : base(exporter) { }

    public override void Export()
    {
        Console.WriteLine($"\n--- {REPORT_TITLE} 준비 중 ---");
        // 실제 데이터와 제목을 Exporter에 위임합니다.
        _exporter.ExportData(REPORT_TITLE, _salesData);
    }
}