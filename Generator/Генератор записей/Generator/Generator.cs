using System;
using System.Collections.Generic;
using Converters;
using Ninject;
using RecordsGenerator.FieldsGenerator;
using RecordsGenerator.Parameters_of_Generator;

namespace RecordsGenerator
{
    public class Generator
    {
        public static Random Random = new Random(DateTime.Now.Millisecond);
        public string[] Methods { get; set; }
        public string[] Extensions { get; set; }
        public string[] Protocols { get; set; }
        public string[] ServerResponseCodes { get; set; }
        public int NumberOfUniqueIp { get; set; }
        public int MinIntervalInMilliseconds { get; set; }
        public int MaxIntervalInMilliseconds { get; set; }
        public int MinNumberOfFolders { get; set; }
        public int MaxNumberOfFolders { get; set; }
        public int MinNumberOfCharacters { get; set; }
        public int MaxNumberOfCharacters { get; set; }
        public int MinSizeOfResponse { get; set; }
        public int MaxSizeOfResponse { get; set; }

        public Settings.Settings Settings { get; set; }

        private IpGeneratorParameters _ipGeneratorParameters;
        private QueryTimeGeneratorParameters _queryTimeGeneratorParameters;
        private QueryMethodGeneratorParameters _queryMethodGeneratorParameters;
        private FileNameGeneratorParameters _fileNameGeneratorParameters;
        private ExtensionGeneratorParameters _extensionGeneratorParameters;
        private ProtocolGeneratorParameters _protocolGeneratorParameters;
        private ServerResponseCodeGeneratorParameters _serverResponseCodeGeneratorParameters;
        private SizeOfResponseGeneratorParameters _sizeOfResponseGeneratorParameters;
        private UniqueIpListGeneratorParameters _uniqueIpListGeneratorParameters;

        private IpGenerator _ip;
        private QueryTimeGenerator _queryTime;
        private QueryMethodGenerator _queryMethod;
        private FileNameGenerator _fileName;
        private ExtensionGenerator _extension;
        private ProtocolGenerator _protocol;
        private ServerResponseCodeGenerator _serverResponseCode;
        private SizeOfResponseGenerator _sizeOfTheResponse;
        private UniqueIpListGenerator _uniqueIpList;

        public Dictionary<string, int> UniqueIpList; 

        public DateTime StartTime; 

        private IKernel _kernel;

        public Generator()
        {
            _kernel = new StandardKernel();
            
        }
        private Record GenerateRecord()
        {
            var record = new Record
            {
                Ip = _ip.Generate(_ipGeneratorParameters).Ip,
                QueryTime = _queryTime.Generate(_queryTimeGeneratorParameters).QueryTime,
                QueryMethod = _queryMethod.Generate(_queryMethodGeneratorParameters).QueryMethod,
                FileName = _fileName.Generate(_fileNameGeneratorParameters).FileName,
                Extension = _extension.Generate(_extensionGeneratorParameters).Extension,
                Protocol = _protocol.Generate(_protocolGeneratorParameters).Protocol,
                ServerResponseCode = _serverResponseCode.Generate(_serverResponseCodeGeneratorParameters).ServerResponseCode,
                SizeOfTheResponse = Convert.ToInt32(_sizeOfTheResponse.Generate(_sizeOfResponseGeneratorParameters).SizeOfResponse)
            };
            return record;
        }

        public List<Record> GenerateRecords(int numberOfRecords)
        {

            #region Generator's Parameters Initialization

            _uniqueIpList = _kernel.Get<UniqueIpListGenerator>();
            _uniqueIpListGeneratorParameters = new UniqueIpListGeneratorParameters
            {
                NumberOfUniqueIp = NumberOfUniqueIp
            };

            UniqueIpList = _uniqueIpList.Generate(_uniqueIpListGeneratorParameters).UniqueIpList;
            _ipGeneratorParameters = new IpGeneratorParameters
            {
                UniqueIpList = UniqueIpList
            };

            _queryTimeGeneratorParameters = new QueryTimeGeneratorParameters
            {
                MinInterval = MinIntervalInMilliseconds,
                MaxInterval = MaxIntervalInMilliseconds,
                StartTime = DateTime.Now
            };

            _queryMethodGeneratorParameters = new QueryMethodGeneratorParameters
            {
                Values = Methods,
                ValuesWithWeights = Settings
            };

            _fileNameGeneratorParameters = new FileNameGeneratorParameters
            {
                MinNumberOfCharacters = MinNumberOfCharacters,
                MaxNumberOfCharacters = MaxNumberOfCharacters,
                MinNumberOfFolders = MinNumberOfFolders,
                MaxNumberOfFolders = MaxNumberOfFolders
            };

            _extensionGeneratorParameters = new ExtensionGeneratorParameters
            {
                Values = Extensions,
                ValuesWithWeights = Settings
            };

            _protocolGeneratorParameters = new ProtocolGeneratorParameters
            {
                Values = Protocols
            };

            _serverResponseCodeGeneratorParameters = new ServerResponseCodeGeneratorParameters
            {
                Values = ServerResponseCodes,
                ValuesWithWeights = Settings
            };

            _sizeOfResponseGeneratorParameters = new SizeOfResponseGeneratorParameters
            {
                MinSize = MinSizeOfResponse,
                MaxSize = MaxSizeOfResponse
            };
            #endregion

            #region Creation of generators
            _ip = _kernel.Get<IpGenerator>();
            _queryTime = _kernel.Get<QueryTimeGenerator>();
            _queryMethod = _kernel.Get< QueryMethodGenerator>();
            _fileName = _kernel.Get<FileNameGenerator>();
            _extension = _kernel.Get<ExtensionGenerator>();
            _protocol = _kernel.Get<ProtocolGenerator>();
            _serverResponseCode = _kernel.Get<ServerResponseCodeGenerator>();
            _sizeOfTheResponse = _kernel.Get<SizeOfResponseGenerator>();
            #endregion

            var listOfRecords = new List<Record>();
            for (var i = 0; i < numberOfRecords; i++)
                listOfRecords.Add(GenerateRecord());
            return listOfRecords;
        }
    }
}
