using System.Collections.Generic;
using Converters;

namespace RecordAnalyzer.AnalyzersReports
{
    public class IpAnalyzerReport : IAnalyzerReport
    {
        public List<string> IpList { get; set; }
        public List<Record> Records { get; set; }
    }
}
