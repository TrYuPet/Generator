using RecordsGenerator.GeneratedValues;
using RecordsGenerator.Parameters_of_Generator;

namespace RecordsGenerator.FieldsGenerator
{
    public class QueryMethodGenerator : IGenerator<GeneratedQueryMethod, QueryMethodGeneratorParameters>
    {
        public GeneratedQueryMethod Generate(QueryMethodGeneratorParameters parameters)
        {
            var randomValueGenerator = new RandomValueGenerator(parameters.Rand);
            return new GeneratedQueryMethod
            {
                QueryMethod = parameters.ValuesWithWeights == null
                    ? parameters.Values[parameters.Rand.Next(parameters.Values.Length)]
                    : randomValueGenerator.GetRandomValue(parameters.Values,
                        Settings.Settings.SumOfWeights(parameters.Values,
                            parameters.ValuesWithWeights.MethodsWithWeights),
                        parameters.ValuesWithWeights.MethodsWithWeights)
            };
        }
    }
}
