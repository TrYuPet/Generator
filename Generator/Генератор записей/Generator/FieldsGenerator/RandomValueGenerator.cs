using System;
using System.Collections.Generic;

namespace RecordsGenerator.FieldsGenerator
{
    public class RandomValueGenerator
    {
        private readonly Random _rand;
        public RandomValueGenerator(Random rand)
        {
            _rand = rand;
        }
        public string GetRandomValue(ICollection<string> values, int sumOfWeights, List<KeyValuePair<string, int>> valuesWithWeights)
        {
            var randomWeight = _rand.Next(1, sumOfWeights);
            int previousWeight = 0, tempWeight = 0;
            var keyValuePairs = valuesWithWeights;
            foreach (var value in values)
            {
                var weightCoefficient = Settings.Settings.FindWeightingCoefficient(value, keyValuePairs);
                tempWeight += weightCoefficient != -1
                    ? weightCoefficient
                    : sumOfWeights / values.Count;
                if (randomWeight <= tempWeight && randomWeight > previousWeight)
                    return value;
                previousWeight = tempWeight;
            }
            return String.Empty;
        }
    }
}
