using System;
using RecordsGenerator.GeneratedValues;
using RecordsGenerator.Parameters_of_Generator;

namespace RecordsGenerator.FieldsGenerator
{
    public class QueryTimeGenerator : IGenerator<GeneratedQueryTime, QueryTimeGeneratorParameters>
    {
        public GeneratedQueryTime Generate(QueryTimeGeneratorParameters parameters)
        {
            var queryTime = parameters.StartTime;
            parameters.StartTime = parameters.StartTime.AddMilliseconds(parameters.Rand.Next(parameters.MinInterval, parameters.MaxInterval));
            return new GeneratedQueryTime {QueryTime = queryTime};
        }
    }
}
