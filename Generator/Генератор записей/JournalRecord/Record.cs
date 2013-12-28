using System;

namespace Converters
{
    public class Record
    {
        public string Ip { get; set; }
        public DateTime QueryTime { get; set; }
        public string QueryMethod { get; set; }
        public string FileName { get; set; }
        public string Extension { get; set; }
        public string Protocol { get; set; }
        public string ServerResponseCode { get; set; }
        public int SizeOfTheResponse { get; set; }
    }
}
