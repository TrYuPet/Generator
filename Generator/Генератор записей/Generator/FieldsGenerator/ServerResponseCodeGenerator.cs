using RecordsGenerator.GeneratedValues;
using RecordsGenerator.Parameters_of_Generator;

namespace RecordsGenerator.FieldsGenerator
{
    public class ServerResponseCodeGenerator : IGenerator<GeneratedServerResponseCode, ServerResponseCodeGeneratorParameters>
    {
        public GeneratedServerResponseCode Generate(ServerResponseCodeGeneratorParameters parameters)
        {
            var randomValueGenerator = new RandomValueGenerator(parameters.Rand);
            return new GeneratedServerResponseCode
            {
                ServerResponseCode = parameters.ValuesWithWeights == null
                    ? parameters.Values[parameters.Rand.Next(parameters.Values.Length)]
                    : randomValueGenerator.GetRandomValue(parameters.Values,
                        Settings.Settings.SumOfWeights(parameters.Values,
                            parameters.ValuesWithWeights.ServerResponseCodesWithWeights),
                        parameters.ValuesWithWeights.ServerResponseCodesWithWeights)
            };
        }
    }
}
