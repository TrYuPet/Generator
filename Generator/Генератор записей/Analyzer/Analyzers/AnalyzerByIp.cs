using System.Collections.Generic;
using System.Linq;
using RecordAnalyzer.AnalyzersReports;
using RecordAnalyzer.ParametersAnalyzers;

namespace RecordAnalyzer.Analyzers
{
    public class AnalyzerByIp : IAnalyzer<AnalyzerParameters, IpAnalyzerReport>
    {
        public IpAnalyzerReport Analyze(AnalyzerParameters parameters)
        {
            var report = new IpAnalyzerReport();
            var ipDictionary = new Dictionary<string, int>();
            for (var i = 0; i < parameters.Records.Count;i++)
            {
                if(!ipDictionary.ContainsKey(parameters.Records[i].Ip))
                    ipDictionary.Add(parameters.Records[i].Ip, 1);
            }
            report.IpList = ipDictionary.Keys.ToList();
            return report;
        }
    }
}
