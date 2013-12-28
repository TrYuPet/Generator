using RecordsGenerator.GeneratedValues;
using RecordsGenerator.Parameters_of_Generator;

namespace RecordsGenerator.FieldsGenerator
{
    public class ProtocolGenerator : IGenerator<GeneratedProtocol, ProtocolGeneratorParameters>
    {
        public GeneratedProtocol Generate(ProtocolGeneratorParameters parameters)
        {
            return new GeneratedProtocol {Protocol = parameters.Values[parameters.Rand.Next(parameters.Values.Length)]};
        }
    }
}
