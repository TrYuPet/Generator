using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Converters;
using Ninject;
using RecordAnalyzer.Analyzers;
using RecordAnalyzer.ParametersAnalyzers;
using RecordAnalyzer.ReportsConverter;

namespace RecordAnalyzer
{
    public class FileAnalyzer
    {
        public List<Record> Records { get; set; }
        private readonly IKernel _kernel;
        private AnalyzerParameters _parameters;

        public FileAnalyzer()
        {
            _kernel = new StandardKernel();
        }

        public string AnalyzeByType(string analyzerType)
        {
            _parameters = new AnalyzerParameters
            {
                Records = Records
            };

            if (analyzerType == "analyzerbyip")
            {
                var analyzerByIp = _kernel.Get<AnalyzerByIp>();
                var converter = _kernel.Get<IpAnalyzerReportConverter>();
                return converter.Convert(analyzerByIp.Analyze(_parameters));
            }

            if (analyzerType == "analyzerbysumofbytes")
            {
                var analyzerBySumOfByte = _kernel.Get<AnalyzerSumOfBytes>();
                var reportConverterBySumOfBytes = _kernel.Get<SumOfBytesAnalyzerReportConverter>();
                return reportConverterBySumOfBytes.Convert(analyzerBySumOfByte.Analyze(_parameters));
            }

            if (analyzerType != null && Regex.IsMatch(analyzerType, @"analyzerbyweights\.\w+"))
            {
                var analyzerByWeights = _kernel.Get<AnalyzerByWeightings>();
                analyzerByWeights.TypeOfWeightAnalyzer = analyzerType.Split('.')[1];
                var reportConverterByWeights = _kernel.Get<WeightsAnalyzerReportConverter>();
                return reportConverterByWeights.Convert(analyzerByWeights.Analyze(_parameters));
            }

            return String.Empty;
        }
    }
}
