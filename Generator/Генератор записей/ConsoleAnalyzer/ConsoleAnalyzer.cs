using System;
using CommandLineTools;
using RecordAnalyzer;

namespace ConsoleAnalyzer
{
    class ConsoleAnalyzer
    {
        static void Main(string[] args)
        {
            var parametersValidator = new ParametersValidator();
            var parametersAreValid = parametersValidator.Validate(args);

            if (parametersAreValid)
            {
                string nameOfFile;
                var parameters = CommandLineParser.Parse(args);
                if (parameters.TryGetValue("nameoffile", out nameOfFile))
                {
                    string analyzerType, startDate, finishDate;
                    parameters.TryGetValue("analyzer", out analyzerType); 
                    parameters.TryGetValue("startdate", out startDate); 
                    parameters.TryGetValue("finishdate", out finishDate);

                    var logReader = new LogFileReader();
                    var records = logReader.GiveAllRecordsInFile(nameOfFile);

                    var dateFilter = new DateFilter
                    {
                        Records = records
                    };
                    records = dateFilter.Filtrate(startDate, finishDate);

                    var analyzerByType = new FileAnalyzer
                    {
                        Records = records
                    };

                    Console.WriteLine(analyzerByType.AnalyzeByType(analyzerType));
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
