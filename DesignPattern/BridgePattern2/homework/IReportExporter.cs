using System;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace BridgePattern2.homework;

public interface IReportExporter
{
    void ExportData(string title, List<object> data);
}