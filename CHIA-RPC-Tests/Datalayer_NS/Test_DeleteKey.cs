using CHIA_RPC.Datalayer_NS;
using CHIA_RPC.General_NS;
using CHIA_RPC_Tests.Testhelpers;

namespace CHIA_RPC_Tests.Datalayer_NS
{
    public class Test_DeleteKey
    {
        private string[] ExpectedRPCResults = new string[]
        {
            "{\"id\":\"0x1163ac212bd5fe00efa86f8d3c4958cda08924870800d72dc332f508a1b2e35a\", \"key\":\"0001\", \"fee\":\"100000\"}",
        };
        string[] ExpectedResponseResults = new string[]
        {
            "{\r\n  \"success\": true,\r\n  \"tx_id\": \"0x6cfbaff3f739f4b0e1d0fae3475966f0d4a19b8a89b483af1bf1cdc789bb9f3c\"\r\n}"
        };

        [Fact]
        public void Test_RPCSerialisation()
        {
           
            Test_RPCClasses<DeleteKey_RPC> helper = new Test_RPCClasses<DeleteKey_RPC>();
            helper.Test_RPCSerialisation(ExpectedRPCResults);
        }
        [Fact]
        public void Test_RPCDiskIO()
        {
            Test_RPCClasses<DeleteKey_RPC> helper = new Test_RPCClasses<DeleteKey_RPC>();
            helper.Test_RPCDiskIO(ExpectedRPCResults);
        }
        [Fact]
        public void Test_ResponseSerialisation()
        {
            
            Test_ResponseClasses<TxID_Response> helper = new Test_ResponseClasses<TxID_Response>();
            helper.Test_ResponseSerialisation(ExpectedResponseResults);
        }
        [Fact]
        public void Test_ResponseDiskIO()
        {
            Test_ResponseClasses<TxID_Response> helper = new Test_ResponseClasses<TxID_Response>();
            helper.Test_ResponseDiskIO(ExpectedResponseResults);
        }
    }
}
