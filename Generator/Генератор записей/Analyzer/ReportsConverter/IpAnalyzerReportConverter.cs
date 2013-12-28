using System.Globalization;
using System.Text;
using RecordAnalyzer.AnalyzersReports;

namespace RecordAnalyzer.ReportsConverter
{
    public class IpAnalyzerReportConverter : IReportConverter<IpAnalyzerReport, string>
    {
        public string Convert(IpAnalyzerReport report)
        {
            var stringReport = new StringBuilder();
            stringReport.Append("Count of unique ip: ");
            stringReport.AppendLine(report.IpList.Count.ToString(CultureInfo.InvariantCulture));
            stringReport.Append(string.Join("\r\n", report.IpList));
            return stringReport.ToString();
        }
    }
}
