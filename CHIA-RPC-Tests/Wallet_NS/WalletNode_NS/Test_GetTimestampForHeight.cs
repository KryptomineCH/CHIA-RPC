using CHIA_RPC.General_NS;
using CHIA_RPC.Wallet_NS.WalletNode_NS;
using CHIA_RPC_Tests.Testhelpers;

namespace CHIA_RPC_Tests.Wallet_NS.WalletNode_NS
{
    public class Test_GetTimestampForHeight
    {
        private string[] ExpectedRPCResults = new string[]
        {
            "{\"height\": 2000000}"
        };
        string[] ExpectedResponseResults = new string[]
        {
            "{\r\n    \"success\": true,\r\n    \"timestamp\": 1672215722\r\n}"
        };

        [Fact]
        public void Test_RPCSerialisation()
        {
           
            Test_RPCClasses<Height_RPC> helper = new Test_RPCClasses<Height_RPC>();
            helper.Test_Serialisation(ExpectedRPCResults);
        }
        [Fact]
        public void Test_RPCDiskIO()
        {
            Test_RPCClasses<Height_RPC> helper = new Test_RPCClasses<Height_RPC>();
            helper.Test_DiskIO(ExpectedRPCResults);
        }
        [Fact]
        public void Test_ResponseSerialisation()
        {
            
            Test_ResponseClasses<GetTimestampForHeight_Response> helper = new Test_ResponseClasses<GetTimestampForHeight_Response>();
            helper.Test_Serialisation(ExpectedResponseResults);
        }
        [Fact]
        public void Test_ResponseDiskIO()
        {
            Test_ResponseClasses<GetTimestampForHeight_Response> helper = new Test_ResponseClasses<GetTimestampForHeight_Response>();
            helper.Test_DiskIO(ExpectedResponseResults);
        }
    }
}
