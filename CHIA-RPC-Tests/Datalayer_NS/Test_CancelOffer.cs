using CHIA_RPC.Datalayer_NS;
using CHIA_RPC.General_NS;
using CHIA_RPC_Tests.Testhelpers;

namespace CHIA_RPC_Tests.Datalayer_NS
{
    public class Test_CancelOffer
    {
        private string[] ExpectedRPCResults = new string[]
        {
            "{\"trade_id\":\"92652561cc3f40677d7d73513b4dde4a56da1c9edc0cfd9f03bb001b95df42af\", \"secure\":\"true\", \"fee\":\"1000\"}"
        };
        string[] ExpectedResponseResults = new string[]
        {
            "{\r\n  \"success\": true\r\n}"
        };

        [Fact]
        public void Test_RPCSerialisation()
        {
           
            Test_RPCClasses<CancelOffer_RPC> helper = new Test_RPCClasses<CancelOffer_RPC>();
            helper.Test_RPCSerialisation(ExpectedRPCResults);
        }
        [Fact]
        public void Test_RPCDiskIO()
        {
            Test_RPCClasses<CancelOffer_RPC> helper = new Test_RPCClasses<CancelOffer_RPC>();
            helper.Test_RPCDiskIO(ExpectedRPCResults);
        }
        [Fact]
        public void Test_ResponseSerialisation()
        {
            
            Test_ResponseClasses<Success_Response> helper = new Test_ResponseClasses<Success_Response>();
            helper.Test_ResponseSerialisation(ExpectedResponseResults);
        }
        [Fact]
        public void Test_ResponseDiskIO()
        {
            Test_ResponseClasses<Success_Response> helper = new Test_ResponseClasses<Success_Response>();
            helper.Test_ResponseDiskIO(ExpectedResponseResults);
        }
    }
}
