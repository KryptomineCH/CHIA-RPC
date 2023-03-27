using CHIA_RPC.Datalayer_NS;
using CHIA_RPC.Datalayer_NS.DatalayerObjects_NS;
using CHIA_RPC.General_NS;
using CHIA_RPC_Tests.Testhelpers;

namespace CHIA_RPC_Tests.Datalayer_NS
{
    public class Test_VerifyOffer
    {
        private string[] ExpectedRPCResults = new string[]
        {
            "{\"offer\": \"596dc917f56ceaf2df17a8cf9672b2e3cd49e2c1432b25834035aafbe063cbae\"}"
        };
        string[] ExpectedResponseResults = new string[]
        {
            "{\r\n  \"error\": null,\r\n  \"fee\": 1,\r\n  \"success\": true,\r\n  \"valid\": true\r\n}"
        };

        [Fact]
        public void Test_RPCSerialisation()
        {
           
            Test_RPCClasses<VerifyOffer_RPC> helper = new Test_RPCClasses<VerifyOffer_RPC>();
            helper.Test_RPCSerialisation(ExpectedRPCResults);
        }
        [Fact]
        public void Test_RPCDiskIO()
        {
            Test_RPCClasses<VerifyOffer_RPC> helper = new Test_RPCClasses<VerifyOffer_RPC>();
            helper.Test_RPCDiskIO(ExpectedRPCResults);
        }
        [Fact]
        public void Test_ResponseSerialisation()
        {
            
            Test_ResponseClasses<VerifyOffer_Response> helper = new Test_ResponseClasses<VerifyOffer_Response>();
            helper.Test_ResponseSerialisation(ExpectedResponseResults);
        }
        [Fact]
        public void Test_ResponseDiskIO()
        {
            Test_ResponseClasses<VerifyOffer_Response> helper = new Test_ResponseClasses<VerifyOffer_Response>();
            helper.Test_ResponseDiskIO(ExpectedResponseResults);
        }
    }
}
