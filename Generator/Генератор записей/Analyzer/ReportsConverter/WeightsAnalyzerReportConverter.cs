using RecordAnalyzer.AnalyzersReports;

namespace RecordAnalyzer.ReportsConverter
{
    public class WeightsAnalyzerReportConverter : IReportConverter<WeightsAnalyzerReport, string>
    {
        public string Convert(WeightsAnalyzerReport report)
        {
            return string.Join("\r\n", report.Probabylities);
        }
    }
}
