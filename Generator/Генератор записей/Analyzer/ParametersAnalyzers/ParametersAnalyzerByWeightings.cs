using System.Collections.Generic;
using Converters;

namespace RecordAnalyzer.ParametersAnalyzers
{
    public class ParametersAnalyzerByWeightings : IParametersAnalyzer
    {
        public string NameOfValues { get; set; }
        public List<Record> Records { get; set; }
    }
}
