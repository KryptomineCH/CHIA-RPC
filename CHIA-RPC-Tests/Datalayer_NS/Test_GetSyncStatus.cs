using CHIA_RPC.Datalayer_NS;
using CHIA_RPC.Datalayer_NS.DatalayerObjects_NS;
using CHIA_RPC.General_NS;
using CHIA_RPC_Tests.Testhelpers;

namespace CHIA_RPC_Tests.Datalayer_NS
{
    public class Test_GetSyncStatus
    {
        private string[] ExpectedRPCResults = new string[]
        {
            "{\"id\": \"39114b28a3674b6c2c0ed65d3518842fd17f9df46794f49cd223f9f3a463f09d\"}"
        };
        string[] ExpectedResponseResults = new string[]
        {
            "{\r\n  \"success\": true,\r\n  \"sync_status\": {\r\n    \"generation\": 1,\r\n    \"root_hash\": \"532d8df550bdbdef28c1a7b27eaefc812afb99eabd59b3c041000c7ea352e900\",\r\n    \"target_generation\": 1,\r\n    \"target_root_hash\": \"532d8df550bdbdef28c1a7b27eaefc812afb99eabd59b3c041000c7ea352e900\"\r\n  }\r\n}"
        };

        [Fact]
        public void Test_RPCSerialisation()
        {
           
            Test_RPCClasses<ID_RPC> helper = new Test_RPCClasses<ID_RPC>();
            helper.Test_Serialisation(ExpectedRPCResults);
        }
        [Fact]
        public void Test_RPCDiskIO()
        {
            Test_RPCClasses<ID_RPC> helper = new Test_RPCClasses<ID_RPC>();
            helper.Test_DiskIO(ExpectedRPCResults);
        }
        [Fact]
        public void Test_ResponseSerialisation()
        {
            
            Test_ResponseClasses<GetSyncStatus_Response> helper = new Test_ResponseClasses<GetSyncStatus_Response>();
            helper.Test_Serialisation(ExpectedResponseResults);
        }
        [Fact]
        public void Test_ResponseDiskIO()
        {
            Test_ResponseClasses<GetSyncStatus_Response> helper = new Test_ResponseClasses<GetSyncStatus_Response>();
            helper.Test_DiskIO(ExpectedResponseResults);
        }
    }
}
