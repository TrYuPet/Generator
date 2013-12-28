namespace Converters.RecordsConverter
{
    public class RecordFormat
    {
        public bool IpIsPresent { get; set; }
        public bool QueryTimeIsPresent { get; set; }
        public bool QueryMethodIsPresent { get; set; }
        public bool FileNameIsPresent { get; set; }
        public bool ExtensionIsPresent { get; set; }
        public bool ProtocolIsPresent { get; set; }
        public bool ServerResponseCodeIsPresent { get; set; }
        public bool SizeOfTheResponseIsPresent { get; set; }
    }
}
