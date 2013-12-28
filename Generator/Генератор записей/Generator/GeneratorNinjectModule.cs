using System;
using System.Collections.Generic;
using Ninject.Modules;
using RecordsGenerator.FieldsGenerator;
using RecordsGenerator.GeneratedValues;
using RecordsGenerator.Parameters_of_Generator;

namespace RecordsGenerator
{
    public class GeneratorNinjectModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IGenerator<GeneratedIp, IpGeneratorParameters>>().To<IpGenerator>();
            Bind<IGenerator<GeneratedQueryTime, QueryTimeGeneratorParameters>>().To<QueryTimeGenerator>();
            Bind<IGenerator<GeneratedQueryMethod, QueryMethodGeneratorParameters>>().To<QueryMethodGenerator>();
            Bind<IGenerator<GeneratedFileName, FileNameGeneratorParameters>>().To<FileNameGenerator>();
            Bind<IGenerator<GeneratedExtension, ExtensionGeneratorParameters>>().To<ExtensionGenerator>();
            Bind<IGenerator<GeneratedProtocol, ProtocolGeneratorParameters>>().To<ProtocolGenerator>();
            Bind<IGenerator<GeneratedServerResponseCode, ServerResponseCodeGeneratorParameters>>().To<ServerResponseCodeGenerator>();
            Bind<IGenerator<GeneratedSizeOfResponse, SizeOfResponseGeneratorParameters>>().To<SizeOfResponseGenerator>();
            Bind<IGenerator<GeneratedUniqueIpList, UniqueIpListGeneratorParameters>>().To<UniqueIpListGenerator>();
        }
    }
}
