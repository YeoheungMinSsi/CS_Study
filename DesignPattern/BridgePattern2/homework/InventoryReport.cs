using System.Collections.Generic;
using System;

namespace BridgePattern2.homework;

public class InventoryReport : Report
{
    // 임시 데이터
    private List<object> _inventoryData = new List<object> { "Stock: 50", "Stock: 200", "Stock: 10" , "Stock: 5" };
    private const string REPORT_TITLE = "재고 리포트";

    public InventoryReport(IReportExporter exporter) : base(exporter) { }

    public override void Export()
    {
        Console.WriteLine($"\n--- {REPORT_TITLE} 준비 중 ---");
        // 실제 데이터와 제목을 Exporter에 위임합니다.
        _exporter.ExportData(REPORT_TITLE, _inventoryData);
    }
}