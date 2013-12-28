using Ninject.Modules;
using RecordAnalyzer.Analyzers;
using RecordAnalyzer.AnalyzersReports;
using RecordAnalyzer.ParametersAnalyzers;
using RecordAnalyzer.ReportsConverter;

namespace RecordAnalyzer
{
    public class AnalyzerNinjectModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IAnalyzer<AnalyzerParameters, IpAnalyzerReport>>().To<AnalyzerByIp>();
            Bind<IAnalyzer<AnalyzerParameters, SumOfBytesAnalyzerReport>>().To<AnalyzerSumOfBytes>();
            Bind<IAnalyzer<AnalyzerParameters, WeightsAnalyzerReport>>().To<AnalyzerByWeightings>();

            Bind<IReportConverter<IpAnalyzerReport, string>>().To<IpAnalyzerReportConverter>();
            Bind<IReportConverter<WeightsAnalyzerReport, string>>().To<WeightsAnalyzerReportConverter>();
            Bind<IReportConverter<SumOfBytesAnalyzerReport, string>>().To<SumOfBytesAnalyzerReportConverter>();

            Bind<IAnalyzerReport>().To<IpAnalyzerReport>();
            Bind<IAnalyzerReport>().To<WeightsAnalyzerReport>();
            Bind<IAnalyzerReport>().To<SumOfBytesAnalyzerReport>();

            Bind<IParametersAnalyzer>().To<AnalyzerParameters>();
        }
    }
}
