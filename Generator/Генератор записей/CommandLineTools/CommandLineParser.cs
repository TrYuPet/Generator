using System.Collections.Generic;

namespace CommandLineTools
{
    public class CommandLineParser
    {
        public static Dictionary<string, string> Parse(string[] parameters)
        {
            var dictionary = new Dictionary<string, string>();
            foreach (var parameter in parameters)
            {
                var parameterName = parameter.Split('=')[0].Remove(0, 2);
                var parameterValue = parameter.Split('=')[1];
                dictionary.Add(parameterName, parameterValue);
            }
            return dictionary;
        }
    }
}
