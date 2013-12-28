using System;
using System.Collections.Generic;
using System.Globalization;
using RecordsGenerator.GeneratedValues;
using RecordsGenerator.Parameters_of_Generator;

namespace RecordsGenerator.FieldsGenerator
{
    public class UniqueIpListGenerator : IGenerator<GeneratedUniqueIpList, UniqueIpListGeneratorParameters>
    {
        public GeneratedUniqueIpList Generate(UniqueIpListGeneratorParameters parameters)
        {
            var ipDictionary = new Dictionary<string, int>();
            while (ipDictionary.Keys.Count < parameters.NumberOfUniqueIp)
            {
                var tempIp = new string[4];
                tempIp[0] = parameters.Rand.Next(128).ToString(CultureInfo.InvariantCulture);
                tempIp[1] = parameters.Rand.Next(255).ToString(CultureInfo.InvariantCulture);
                tempIp[2] = parameters.Rand.Next(255).ToString(CultureInfo.InvariantCulture);
                tempIp[3] = parameters.Rand.Next(255).ToString(CultureInfo.InvariantCulture);
                var ip = String.Join(".", tempIp);
                if (!ipDictionary.ContainsKey(ip))
                {
                    ipDictionary.Add(ip, 0);
                }
            }
            return new GeneratedUniqueIpList {UniqueIpList = ipDictionary};
        }
    }
}
