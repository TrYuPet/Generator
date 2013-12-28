namespace RecordsGenerator.Parameters_of_Generator
{
    public class ExtensionGeneratorParameters : Rng, IParametersGenerator
    {
        public string[] Values { get; set; }
        public Settings.Settings ValuesWithWeights { get; set; }
    }
}
