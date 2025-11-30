using System;
using System.Collections.Generic;

namespace BridgePattern2.homework;

public abstract class Report
{
    // Implementor에 대한 참조 필드
    protected IReportExporter _exporter;
        
    // 런타임 교체를 위한 Public 속성 (Bridge Access Point)
    public IReportExporter OutputImple
    {
        get { return _exporter; }
        set
        {
            if(value == null)
                throw new ArgumentNullException(nameof(value), "Exporter 구현체는 null일 수 없습니다.");
            _exporter = value;
        }
    }

    // 생성자: ReportExporter 객체를 주입받아 초기화합니다.
    public Report(IReportExporter exporter)
    {
        _exporter = exporter;
    }

    // 클라이언트가 호출하는 추상 메서드
    public abstract void Export();
}