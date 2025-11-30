using System.Collections.Generic;
using System;

namespace BridgePattern2.homework;

public class UserReport : Report
{
    // 임시 데이터
    private List<object> _userData = new List<object> { "User ID: 101", "User ID: 102", "User ID: 103" };
    private const string REPORT_TITLE = "사용자 리포트";

    public UserReport(IReportExporter exporter) : base(exporter) { }

    public override void Export()
    {
        Console.WriteLine($"\n--- {REPORT_TITLE} 준비 중 ---");
        // 실제 데이터와 제목을 Exporter에 위임합니다.
        _exporter.ExportData(REPORT_TITLE, _userData);
    }
}