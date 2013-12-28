using System;
using System.Text;
using RecordsGenerator.GeneratedValues;
using RecordsGenerator.Parameters_of_Generator;

namespace RecordsGenerator.FieldsGenerator
{
    public class FileNameGenerator : IGenerator<GeneratedFileName, FileNameGeneratorParameters>
    {
        public string GenerateCharacterSequence(Random random, int numberOfCharacters)
        {
            var sequence = new StringBuilder();
            for (var i = 0; i < numberOfCharacters; i++)
            {
                sequence.Append(Convert.ToChar(random.Next(97, 122)));
            }
            return sequence.ToString();
        }

        public GeneratedFileName Generate(FileNameGeneratorParameters parameters)
        {
            var numberOfFolders = parameters.Rand.Next(parameters.MinNumberOfFolders, parameters.MaxNumberOfFolders);
            var tempFileName = new string[numberOfFolders];

            for (var i = 0; i < numberOfFolders; i++)
            {
                var numberOfCharacters = parameters.Rand.Next(parameters.MinNumberOfCharacters, parameters.MaxNumberOfCharacters);
                tempFileName[i] = GenerateCharacterSequence(parameters.Rand, numberOfCharacters);
            }
            return new GeneratedFileName {FileName = String.Join("/", tempFileName)};
        }
    }
}
