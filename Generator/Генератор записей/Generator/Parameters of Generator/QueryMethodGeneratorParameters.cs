namespace RecordsGenerator.Parameters_of_Generator
{
    public class QueryMethodGeneratorParameters : Rng, IParametersGenerator
    {
        public string[] Values { get; set; }
        public Settings.Settings ValuesWithWeights { get; set; }
    }
}
