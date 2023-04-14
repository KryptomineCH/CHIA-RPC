using CHIA_RPC.Datalayer_NS;
using CHIA_RPC.General_NS;
using CHIA_RPC.Wallet_NS.RoutesAndConnections_NS;
using CHIA_RPC_Tests.Testhelpers;

namespace CHIA_RPC_Tests.Datalayer_NS
{
    public class Test_CloseConnection
    {
        private string[] ExpectedRPCResults = new string[]
        {
            "{\"node_id\":\"0x8e961b617579d476419003728d6d71ab1b182f7d962e5db16f61ebfb157d771b\"}"
        };
        string[] ExpectedResponseResults = new string[]
        {
            "{\r\n  \"success\": true\r\n}"
        };

        [Fact]
        public void Test_RPCSerialisation()
        {
           
            Test_RPCClasses<CloseConnection_RPC> helper = new Test_RPCClasses<CloseConnection_RPC>();
            helper.Test_Serialisation(ExpectedRPCResults);
        }
        [Fact]
        public void Test_RPCDiskIO()
        {
            Test_RPCClasses<CloseConnection_RPC> helper = new Test_RPCClasses<CloseConnection_RPC>();
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
