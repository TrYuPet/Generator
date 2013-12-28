using System.IO;
using System.Text.RegularExpressions;

namespace Settings
{
    public class YamlReader
    {
        public static JournalConfiguration[] ConvertYamlFileToConfigurations(string path)
        {
            const string pattern = @"\{(?<Key1>\w+)\:(?<Value1>\w+)\,(?<Key2>\w+)\:(?<Value2>\w+)\}";
            var fileReader = new StreamReader(path);
            var rows = fileReader.ReadToEnd().Split('\n');
            fileReader.Close();
            var configs = new JournalConfiguration[rows.Length];
            for (var i = 0; i < rows.Length; i++)
            {
                var matshes = Regex.Match(rows[i], pattern);
                configs[i] = new JournalConfiguration
                {
                    Key1 = matshes.Groups[1].Value,
                    Key2 = matshes.Groups[3].Value,
                    Value1 = matshes.Groups[2].Value,
                    Value2 = matshes.Groups[4].Value
                };
            }
            return configs;
        }
    }
}
