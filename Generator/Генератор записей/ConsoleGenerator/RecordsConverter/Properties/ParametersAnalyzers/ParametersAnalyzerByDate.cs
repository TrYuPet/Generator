using System.Collections.Generic;
using RecordAnalyzer.ParametersAnalyzers;

namespace Converters.Properties.ParametersAnalyzers
{
    class ParametersAnalyzerByDate : IParametersAnalyzer
    {
        public List<Record> Records { get; set; }
        public string StartTime { get; set; }
        public string FinishTime { get; set; }
    }
}
