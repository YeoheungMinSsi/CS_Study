using System;
using System.Collections.Generic;

namespace BridgePattern2.homework;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("=================================================");
        Console.WriteLine("    [과제 2] 리포트 출력 시스템 브릿지 패턴 데모");
        Console.WriteLine("=================================================");
            
        // --- 1. 기본 출력 테스트: SalesReport + CSVExporter 조합 ---
        Console.WriteLine("\n[테스트 1] SalesReport + CSVExporter 조합");
        Report salesCsvReport = new SalesReport(new CSVExporter());
        salesCsvReport.Export();
            
        // --- 2. 출력 형식 교체 테스트: 동일 Report에 PDFExporter 주입 (조합 다양성) ---
        Console.WriteLine("\n[테스트 2] UserReport + PDFExporter 조합");
        Report userPdfReport = new UserReport(new PDFExporter());
        userPdfReport.Export();
            
        // --- 3. 런타임 교체 테스트: SalesReport의 Exporter를 PDF로 교체 ---
        Console.WriteLine("\n[테스트 3] 런타임에 SalesReport의 Exporter를 PDF로 교체");
        salesCsvReport.OutputImple = new PDFExporter();
        salesCsvReport.Export();
            
        // --- 4. 리포트 확장 테스트: InventoryReport 추가 (기존 Exporter와 조합) ---
        Console.WriteLine("\n[테스트 4] InventoryReport + CSVExporter 조합 (리포트 확장성 검증)");
        Report inventoryCsvReport = new InventoryReport(new CSVExporter());
        inventoryCsvReport.Export();

        // --- 5. 출력 포맷 확장 테스트: JSONExporter 추가 (기존 Report와 조합) ---
        Console.WriteLine("\n[테스트 5] SalesReport + JSONExporter 조합 (출력 포맷 확장성 검증)");
        Report salesJsonReport = new SalesReport(new JSONExporter());
        salesJsonReport.Export();

        // --- 6. 조합 다양성 검증: InventoryReport + JSONExporter ---
        Console.WriteLine("\n[테스트 6] InventoryReport + JSONExporter 조합");
        Report inventoryJsonReport = new InventoryReport(new JSONExporter());
        inventoryJsonReport.Export();
    }
}