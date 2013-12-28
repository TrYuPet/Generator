using System;
using System.Collections.Generic;
using Converters;

namespace RecordAnalyzer
{
    public class DateFilter
    {
        private DateTime _startDate;
        private DateTime _finishDate;
        public List<Record> Records { get; set; }

        public List<Record> Filtrate(string startDate, string finishDate)
        {
            if (startDate == String.Empty || string.IsNullOrEmpty(startDate))
                _startDate = Records[0].QueryTime;
            else
            {
                _startDate = DateConverter.StringToDate(startDate);
            }
            if (finishDate == String.Empty || string.IsNullOrEmpty(finishDate))
                _finishDate = Records[Records.Count - 1].QueryTime;
            else
            {
                _finishDate = DateConverter.StringToDate(finishDate);
            }

            var tempRecords = new List<Record>();
            for (var i = 0; i < Records.Count; i++)
            {
                if ((Records[i].QueryTime >= _startDate) && (Records[i].QueryTime <= _finishDate))
                    tempRecords.Add(Records[i]);
            }
            return tempRecords;
        }
    }
}
