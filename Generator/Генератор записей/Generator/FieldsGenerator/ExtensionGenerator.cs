using RecordsGenerator.GeneratedValues;
using RecordsGenerator.Parameters_of_Generator;

namespace RecordsGenerator.FieldsGenerator
{
    public class ExtensionGenerator : IGenerator<GeneratedExtension, ExtensionGeneratorParameters>
    {
        public GeneratedExtension Generate(ExtensionGeneratorParameters parameters)
        {
            var randomValueGenerator = new RandomValueGenerator(parameters.Rand);
            return new GeneratedExtension
            {
                Extension = parameters.ValuesWithWeights == null
                    ? parameters.Values[parameters.Rand.Next(parameters.Values.Length)]
                    : randomValueGenerator.GetRandomValue(parameters.Values,
                        Settings.Settings.SumOfWeights(parameters.Values,
                            parameters.ValuesWithWeights.ExtensionsWithWeights),
                        parameters.ValuesWithWeights.ExtensionsWithWeights)
            };
        }
    }
}
