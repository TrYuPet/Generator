using System.Collections.Generic;
using System.IO;
using Converters;

namespace RecordAnalyzer
{
    public class LogFileReader
    {
        private ConverterRowsInRecords RowsConverter { get; set; }

        public List<Record> GiveAllRecordsInFile(string nameOfFile)
        {
            var fileReader = new StreamReader(nameOfFile);
            var rows = fileReader.ReadToEnd().Split('\n');
            fileReader.Close();
            RowsConverter = new ConverterRowsInRecords();
            var records = RowsConverter.RowsToRecord(rows);
            return records;
        }
    }
}
