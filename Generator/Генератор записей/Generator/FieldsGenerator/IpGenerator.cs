using RecordsGenerator.GeneratedValues;
using RecordsGenerator.Parameters_of_Generator;

namespace RecordsGenerator.FieldsGenerator
{
    public class IpGenerator : IGenerator<GeneratedIp, IpGeneratorParameters>
    {
        public GeneratedIp Generate(IpGeneratorParameters parameters)
        {
            foreach (var ip in parameters.UniqueIpList.Keys)
            {
                if (parameters.UniqueIpList[ip] == 0)
                {
                    parameters.UniqueIpList[ip]++;
                    return new GeneratedIp {Ip = ip};
                }
            }
            var index = parameters.Rand.Next(0, parameters.UniqueIpList.Count);
            foreach (var ip in parameters.UniqueIpList.Keys)
            {
                if (index != 0)
                {
                    index--;
                }
                else
                {
                    parameters.UniqueIpList[ip]++;
                    return new GeneratedIp { Ip = ip }; 
                }
            }
            return new GeneratedIp { Ip = string.Empty};
        }
    }
}
