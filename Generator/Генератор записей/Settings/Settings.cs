using System.Collections.Generic;

namespace Settings
{
    public class Settings
    {
        public List<KeyValuePair<string, int>> MethodsWithWeights { get; set; }
        public List<KeyValuePair<string, int>> ServerResponseCodesWithWeights { get; set; }
        public List<KeyValuePair<string, int>> ExtensionsWithWeights { get; set; }

        public static int FindWeightingCoefficient(string key, List<KeyValuePair<string, int>> weightedValues)
        {
            foreach (var value in weightedValues)
            {
                if (value.Key == key)
                    return value.Value;
            }
            return -1;
        }

        public static int SumOfWeights(string[] values, List<KeyValuePair<string, int>> weightedValues)
        {
            var sumOfWeights = 0;
            var weights = new Dictionary<string, int>();

            foreach (var weightedValue in weightedValues)
            {
                sumOfWeights += weightedValue.Value;
                weights.Add(weightedValue.Key, weightedValue.Value);
            }
            var averageWeight = 1;
            if (weightedValues.Count != 0)
                averageWeight = sumOfWeights / weightedValues.Count;

            foreach (var value in values)
            {
                if(!weights.ContainsKey(value))
                {
                    weights.Add(value, averageWeight);
                    sumOfWeights += averageWeight;
                }
            }

            return sumOfWeights;
        }
    }
}
