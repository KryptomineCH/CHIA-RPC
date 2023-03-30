using CHIA_RPC.Datalayer_NS;
using CHIA_RPC.General_NS;
using CHIA_RPC_Tests.Testhelpers;

namespace CHIA_RPC_Tests.Datalayer_NS
{
    public class Test_AddMissingFiles
    {
        private string[] ExpectedRPCResults = new string[]
        {
            "{\"foldername\": \"test\"}",
        };
        private string[] ExpectedResponseResults = new string[]
        {
            "{\r\n  \"success\": true\r\n}",
        };

        [Fact]
        public void Test_RPCSerialisation()
        {
           
            Test_RPCClasses<AddMissingFiles_RPC> helper = new Test_RPCClasses<AddMissingFiles_RPC>();
            helper.Test_Serialisation(ExpectedRPCResults);
        }
        [Fact]
        public void Test_RPCDiskIO()
        {
            Test_RPCClasses<AddMissingFiles_RPC> helper = new Test_RPCClasses<AddMissingFiles_RPC>();
            helper.Test_DiskIO(ExpectedRPCResults);
        }
        [Fact]
        public void Test_ResponseSerialisation()
        {

            Test_ResponseClasses<Success_Response> helper = new Test_ResponseClasses<Success_Response>();
            helper.Test_Serialisation(ExpectedResponseResults);
        }
        [Fact]
        public void Test_ResponseDiskIO()
        {
            Test_ResponseClasses<Success_Response> helper = new Test_ResponseClasses<Success_Response>();
            helper.Test_DiskIO(ExpectedResponseResults);
        }
    }
}
