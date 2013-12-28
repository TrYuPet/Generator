namespace RecordsGenerator.Parameters_of_Generator
{
    public class SizeOfResponseGeneratorParameters : Rng, IParametersGenerator
    {
        public int MinSize { get; set; }
        public int MaxSize { get; set; }
    }
}
