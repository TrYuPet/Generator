using System.Collections.Generic;

namespace RecordsGenerator.Parameters_of_Generator
{
    public class IpGeneratorParameters : Rng, IParametersGenerator
    {
        public Dictionary<string, int> UniqueIpList { get; set; }
    }
}
