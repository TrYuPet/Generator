namespace RecordAnalyzer.Analyzers
{
    interface IAnalyzer<in TL, out T>
    {
        T Analyze(TL parameters);
    }
}
