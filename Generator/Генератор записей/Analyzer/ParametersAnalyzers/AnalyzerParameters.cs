using System.Collections.Generic;
using Converters;

namespace RecordAnalyzer.ParametersAnalyzers
{
    public class AnalyzerParameters : IParametersAnalyzer
    {
        public List<Record> Records { get; set; } 
    }
}
