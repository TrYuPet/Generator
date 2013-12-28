using RecordsGenerator.GeneratedValues;
using RecordsGenerator.Parameters_of_Generator;

namespace RecordsGenerator.FieldsGenerator
{
    public class SizeOfResponseGenerator : IGenerator<GeneratedSizeOfResponse, SizeOfResponseGeneratorParameters>
    {
        public GeneratedSizeOfResponse Generate(SizeOfResponseGeneratorParameters parameters)
        {
            return new GeneratedSizeOfResponse
            {
                SizeOfResponse = parameters.Rand.Next(parameters.MinSize, parameters.MaxSize)
            };
        }
    }
}
