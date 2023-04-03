using CHIA_RPC.General_NS;
using CHIA_RPC_Tests.Testhelpers;

namespace CHIA_RPC_Tests.Wallet_NS.Wallet_NS
{
    public class Test_ExtendDerivationIndex
    { 
        private string[] ExpectedRPCResults = new string[]
        {
            "{\"index\": 436}"
        };
        string[] ExpectedResponseResults = new string[]
        {
            "{\r\n    \"index\": 436,\r\n    \"success\": true\r\n}"
        };

        [Fact]
        public void Test_RPCSerialisation()
        {
           
            Test_RPCClasses<Index_RPC> helper = new Test_RPCClasses<Index_RPC>();
            helper.Test_Serialisation(ExpectedRPCResults);
        }
        [Fact]
        public void Test_RPCDiskIO()
        {
            Test_RPCClasses<Index_RPC> helper = new Test_RPCClasses<Index_RPC>();
            helper.Test_DiskIO(ExpectedRPCResults);
        }
        [Fact]
        public void Test_ResponseSerialisation()
        {
            
            Test_ResponseClasses<Index_Response> helper = new Test_ResponseClasses<Index_Response>();
            helper.Test_Serialisation(ExpectedResponseResults);
        }
        [Fact]
        public void Test_ResponseDiskIO()
        {
            Test_ResponseClasses<Index_Response> helper = new Test_ResponseClasses<Index_Response>();
            helper.Test_DiskIO(ExpectedResponseResults);
        }
    }
}
