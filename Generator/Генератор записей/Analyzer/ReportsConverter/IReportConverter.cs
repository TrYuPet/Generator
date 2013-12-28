namespace RecordAnalyzer.ReportsConverter
{
    interface IReportConverter<in TL, out T>
    {
        T Convert(TL parameters);
    }
}
