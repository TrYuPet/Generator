using System;

namespace RecordsGenerator.Parameters_of_Generator
{
    public class QueryTimeGeneratorParameters : Rng, IParametersGenerator
    {
        public int MinInterval { get; set; }
        public int MaxInterval { get; set; }
        public DateTime StartTime { get; set; }
}
}
