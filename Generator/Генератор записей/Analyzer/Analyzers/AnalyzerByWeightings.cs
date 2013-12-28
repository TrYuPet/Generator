using System;
using System.Collections.Generic;
using RecordAnalyzer.AnalyzersReports;
using RecordAnalyzer.ParametersAnalyzers;

namespace RecordAnalyzer.Analyzers
{
    public class AnalyzerByWeightings : AnalyzerStatistics, IAnalyzer<AnalyzerParameters, WeightsAnalyzerReport>
    {
        private string _type;

        public WeightsAnalyzerReport Analyze(AnalyzerParameters parameters)
        {
            _type = TypeOfWeightAnalyzer;

            var practicalProbabilities = new Dictionary<string, int>();

            if (_type == "Methods")
            {
                foreach (var record in parameters.Records)
                {
                    if (!practicalProbabilities.ContainsKey(record.QueryMethod))
                    {
                        practicalProbabilities.Add(record.QueryMethod, 0);
                    }
                    practicalProbabilities[record.QueryMethod]++;
                }
            }

            if (_type == "Extensions")
            {
                foreach (var record in parameters.Records)
                {
                    if (!practicalProbabilities.ContainsKey(record.Extension))
                    {
                        practicalProbabilities.Add(record.Extension, 0);
                    }
                    practicalProbabilities[record.Extension]++;
                }
            }

            if (_type == "Codes")
            {
                foreach (var record in parameters.Records)
                {
                    if (!practicalProbabilities.ContainsKey(record.ServerResponseCode))
                    {
                        practicalProbabilities.Add(record.ServerResponseCode, 0);
                    }
                    practicalProbabilities[record.ServerResponseCode]++;
                }
            }
            
            var tempReport = new List<string>();
            foreach (var practicalProbability in practicalProbabilities.Keys)
            {
                tempReport.Add(String.Format("{0} - Frequency: {1}, Probabylity: {2}", practicalProbability, practicalProbabilities[practicalProbability],(double)practicalProbabilities[practicalProbability]/parameters.Records.Count));
            }

            return new WeightsAnalyzerReport { Probabylities = tempReport };
        }
    }
}
