namespace RecordsGenerator.Parameters_of_Generator
{
    public class FileNameGeneratorParameters : Rng, IParametersGenerator
    {
        public int MinNumberOfFolders { get; set; }
        public int MaxNumberOfFolders { get; set; }
        public int MinNumberOfCharacters { get; set; }
        public int MaxNumberOfCharacters { get; set; }
    }
}
