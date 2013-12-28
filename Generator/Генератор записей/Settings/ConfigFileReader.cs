using System;
using System.Collections.Generic;

namespace Settings
{
    public class ConfigFileReader
    {
        public Settings Settings { get; private set; }

        public ConfigFileReader(string filePath)
        {
            var yamlConfigs = YamlReader.ConvertYamlFileToConfigurations(filePath);

            Settings = new Settings
            {
                MethodsWithWeights = new List<KeyValuePair<string, int>>(),
                ServerResponseCodesWithWeights = new List<KeyValuePair<string, int>>(),
                ExtensionsWithWeights = new List<KeyValuePair<string, int>>(),
            }; 
            
            foreach (var t in yamlConfigs)
            {
                if (t.Key1 == "methods")
                {
                    Settings.MethodsWithWeights.Add(new KeyValuePair<string, int>(t.Value1, Convert.ToInt32(t.Value2)));
                }
                if (t.Key1 == "extensions")
                {
                    Settings.ExtensionsWithWeights.Add(new KeyValuePair<string, int>(t.Value1, Convert.ToInt32(t.Value2)));
                }
                if (t.Key1 == "serverResponseCodes")
                {
                    Settings.ServerResponseCodesWithWeights.Add(new KeyValuePair<string, int>(t.Value1, Convert.ToInt32(t.Value2)));
                }
            }
        }
    }
}
