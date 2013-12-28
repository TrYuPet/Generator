using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Converters
{
    public class ConverterRowsInRecords
    {
        private const string FullRowPattern = @"(?<Ip>\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3})\ \-\ \- \[(?<Year>\d+)/(?<Month>\d+)/(?<Day>\d+) (?<Hour>\d+)\:(?<Minutes>\d+)\:(?<Seconds>\d+)\:(?<Milliseconds>\d+)\]\ (?<Method>\w+)\ (?<Filename>(\w+\/)+\w+)\.(?<Extension>\w+)\ (?<Protocol>\w+)\ (?<ServerResponseCode>\d+)\ (?<SizeOfTheResponse>\d+)";
        public List<Record> RowsToRecord(string[] rows)
        {
            var records = new List<Record>();
            for (var i = 0; i < rows.Length; i++)
            {
                var matches = Regex.Match(rows[i], FullRowPattern);
                if (matches != Match.Empty)
                {
                    var year = Convert.ToInt32(matches.Groups["Year"].Value);
                    var month = Convert.ToInt32(matches.Groups["Month"].Value);
                    var day = Convert.ToInt32(matches.Groups["Day"].Value);
                    var hour = Convert.ToInt32(matches.Groups["Hour"].Value);
                    var minute = Convert.ToInt32(matches.Groups["Minutes"].Value);
                    var second = Convert.ToInt32(matches.Groups["Seconds"].Value);
                    var millisecond = Convert.ToInt32(matches.Groups["Milliseconds"].Value);
                    var date = new DateTime(year, month, day, hour, minute, second, millisecond);
                    records.Add(new Record
                    {
                        Ip = matches.Groups["Ip"].Value,
                        QueryTime = new DateTime(year, month, day, hour, minute, second, millisecond),
                        QueryMethod = matches.Groups["Method"].Value,
                        FileName = matches.Groups["Filename"].Value,
                        Extension = matches.Groups["Extension"].Value,
                        Protocol = matches.Groups["Protocol"].Value,
                        ServerResponseCode = matches.Groups["ServerResponseCode"].Value,
                        SizeOfTheResponse = Convert.ToInt32(matches.Groups["SizeOfTheResponse"].Value)
                    });
                }
            }
            return records;
        }
    }
}
