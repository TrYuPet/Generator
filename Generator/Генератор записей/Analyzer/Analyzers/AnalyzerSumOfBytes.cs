using RecordAnalyzer.AnalyzersReports;
using RecordAnalyzer.ParametersAnalyzers;

namespace RecordAnalyzer.Analyzers
{
    public class AnalyzerSumOfBytes : IAnalyzer<AnalyzerParameters, SumOfBytesAnalyzerReport>
    {
        public SumOfBytesAnalyzerReport Analyze(AnalyzerParameters parameters)
        {
            var summa = 0;
            for (var i = 0; i < parameters.Records.Count; i++)
            {
                summa += parameters.Records[i].SizeOfTheResponse;
            }
            return new SumOfBytesAnalyzerReport
            {
                Summa = summa
            };
        }
    }
}
