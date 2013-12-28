using System.Collections.Generic;
using System.Text;

namespace Converters.RecordsConverter
{
    public class ApacheLogFormat
    {
        static public string[] RecordsToString(List<Record> records, RecordFormat recordFormat)
        {
            var rows = new string[records.Count];
            for (var i = 0; i < records.Count; i++)
                rows[i] = RecordToString(records[i], recordFormat);
            return rows;
        }

        static private string RecordToString(Record record, RecordFormat recordFormat)
        {
            var tempRecord = new StringBuilder();
            if (recordFormat.IpIsPresent)
            {
                tempRecord.Append(record.Ip);
                tempRecord.Append(" - - ");
            }
            if (recordFormat.QueryTimeIsPresent)
            {
                tempRecord.Append("[");
                tempRecord.Append(DateConverter.DateToString(record.QueryTime));
                tempRecord.Append("] ");
            }
            if (recordFormat.QueryMethodIsPresent)
            {
                tempRecord.Append(record.QueryMethod);
                tempRecord.Append(" ");
            }
            if (recordFormat.FileNameIsPresent)
            {
                tempRecord.Append(record.FileName);
            }
            if (recordFormat.ExtensionIsPresent)
            {
                tempRecord.Append(".");
                tempRecord.Append(record.Extension);
                tempRecord.Append(" ");
            }
            if (recordFormat.ProtocolIsPresent)
            {
                tempRecord.Append(record.Protocol);
                tempRecord.Append(" ");
            }
            if (recordFormat.ServerResponseCodeIsPresent)
            {
                tempRecord.Append(record.ServerResponseCode);
                tempRecord.Append(" ");
            }
            if (recordFormat.SizeOfTheResponseIsPresent)
            {
                tempRecord.Append(record.SizeOfTheResponse);
            }
            return tempRecord.ToString();
        }
    }
}
