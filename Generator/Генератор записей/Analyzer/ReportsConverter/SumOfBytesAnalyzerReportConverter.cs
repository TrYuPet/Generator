using System.Text;
using RecordAnalyzer.AnalyzersReports;

namespace RecordAnalyzer.ReportsConverter
{
    public class SumOfBytesAnalyzerReportConverter:IReportConverter<SumOfBytesAnalyzerReport, string>
    {
        public string Convert(SumOfBytesAnalyzerReport report)
        {
            var sumOfBytesReport = new StringBuilder();
            sumOfBytesReport.Append("Sum of bytes: ");
            sumOfBytesReport.Append(report.Summa);
            return sumOfBytesReport.ToString();
        }
    }
}
