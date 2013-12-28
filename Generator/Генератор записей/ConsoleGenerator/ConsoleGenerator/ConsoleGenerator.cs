using System;
using CommandLineTools;
using Converters.RecordsConverter;
using Save;
using RecordsGenerator;

namespace ConsoleGenerator
{
    class ConsoleGenerator
    {
        static void Main(string[] args)
        {
            var parametersValidator = new ParametersValidator();
            var parametersAreValid = parametersValidator.Validate(args);

            if (parametersAreValid)
            {
                string nameOfFile;
                string numberOfLines;
                string numberOfUniqueIp;
                var parametersDictionary = CommandLineParser.Parse(args);
                if (parametersDictionary.TryGetValue("nameoffile", out nameOfFile) && parametersDictionary.TryGetValue("numberoflines", out numberOfLines) && parametersDictionary.TryGetValue("numberofuniqueip", out numberOfUniqueIp))
                {
                    var uniqueIpCount = Convert.ToInt32(numberOfUniqueIp);
                    var linesLength = Convert.ToInt32(numberOfLines);
                    var configFileReader = new Settings.ConfigFileReader(@"D:\Univercity\Univercity\3курс-лабы\config.yaml");
                    string[] methods =
                    {
                        "POST", "LINK", "DELETE", "PUT", "PATCH", "GET", "OPTIONS", "HEAD", "TRACE", 
                        "UNLINK", "CONNECT"
                    };
                    string[] extensions = {"txt", "pdf", "doc", "exe", "jmp", "cpp", "obj", "iso"};
                    string[] protocols = {"http", "https"};
                    string[] serverResponseCodes = {"200", "401", "204", "404", "501"};
                    const int minIntervalInMilliseconds = 100;
                    const int maxIntervalInMilliseconds = 100000;
                    const int minNumberOfFolders = 3;
                    const int maxNumberOfFolders = 7;
                    const int minNumberOfCharacters = 3;
                    const int maxNumberOfCharacters = 7;
                    const int minSizeOfResponse = 100;
                    const int maxSizeOfResponse = 10000;

                    var recordFormat = new RecordFormat
                    {
                        IpIsPresent = true,
                        QueryTimeIsPresent = true,
                        QueryMethodIsPresent = true,
                        FileNameIsPresent = true,
                        ExtensionIsPresent = true,
                        ProtocolIsPresent = true,
                        ServerResponseCodeIsPresent = true,
                        SizeOfTheResponseIsPresent = true
                    };
                    var generator = new Generator
                    {
                        Extensions = extensions,
                        Protocols = protocols,
                        Methods = methods,
                        Settings = configFileReader.Settings,
                        ServerResponseCodes = serverResponseCodes,
                        MinIntervalInMilliseconds = minIntervalInMilliseconds,
                        MaxIntervalInMilliseconds = maxIntervalInMilliseconds,
                        MinNumberOfCharacters = minNumberOfCharacters,
                        MaxNumberOfCharacters = maxNumberOfCharacters,
                        MinNumberOfFolders = minNumberOfFolders,
                        MaxNumberOfFolders = maxNumberOfFolders,
                        MinSizeOfResponse = minSizeOfResponse,
                        MaxSizeOfResponse = maxSizeOfResponse,
                        NumberOfUniqueIp = uniqueIpCount
                    };
                    var allRecords = generator.GenerateRecords(linesLength);
                    var rows = ApacheLogFormat.RecordsToString(allRecords, recordFormat);
                    SaveToFile.SaveRowsToFile(nameOfFile, rows);
                    Console.WriteLine("Save succesed!");
                }
                else
                {
                    Console.WriteLine("Входные параметры не соответствуют шаблону.");
                }
            }
            else
                Console.WriteLine(parametersValidator.ValidationInformation);
            Console.ReadKey();
        }
    }
}
